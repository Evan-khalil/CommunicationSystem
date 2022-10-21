using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunicationApp.Models;
using CommunicationApp.Repository;
using CommunicationApp.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace CommunicationApp.Controllers
{
    public class DevelopmentController : Controller
    {
        private readonly UserManager<Person> _userManager;
        private readonly ICategoryRepository _category;
        private readonly IPersonRepository _person;
        private readonly IMailRepository _mail;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IBlogPostRepository _blogPost;

        public DevelopmentController(UserManager<Person> userManager, ICategoryRepository categoryRepository,
            IPersonRepository personRepository, IWebHostEnvironment webHostEnvironment, IMailRepository mailRepository, IBlogPostRepository blogPost)
        {
            _userManager = userManager;
            _category = categoryRepository;
            _person = personRepository;
            _webHostEnvironment = webHostEnvironment;
            _mail = mailRepository;
            _blogPost = blogPost;
        }

        public async Task<IActionResult> Index(int? sida, string type)
        {
            var userId = _userManager.GetUserId(User);
            bool isAdminUser = User.IsInRole("Admin");
            int pageSize = 5;
            if (sida is null || sida < 1)
            {
                sida = 1;
            }

            var utvecklingsTyp = new BlogType();
            if (type is not null && type == "Education")
            {
                ViewData["Title"] = "Utbildning";
                utvecklingsTyp = BlogType.Education;
            }
            else
            {
                ViewData["Title"] = "Forskning";
                utvecklingsTyp = BlogType.Research;
            }

            var posts = await _blogPost.Where(p => p.BlogType == utvecklingsTyp)
                .Where(b => isAdminUser || b.Author.Id == userId || b.Categories.Any(c => c.Creator.Id == userId || !c.Participants.Any() || c.Participants.Any(p => p.Id == userId)))
                .Include(c => c.Categories)
                .Include(b => b.Files)
                .Include(a => a.Author)
                .Include(c => c.Comments)
                .ThenInclude(c => c.Author)
                .OrderByDescending(b => b.DateEdited)
                .ToListAsync();

            var viewModel = new DevelopmentViewModel
            {
                BlogPosts = posts.Skip(((int)sida - 1) * pageSize).Take(pageSize).ToList(),
                CurrentPage = (int)sida,
                TotalPages = (int)Math.Ceiling(posts.Count / (decimal)pageSize),
                CurrentUrl = "/Development?type=" + type,
                TotalPosts = posts.Count,
                Categories = await _category.Where(c => c.Type.Equals(utvecklingsTyp)).ToListAsync()
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create(string id, string type)
        {
            var blogTypes = new List<string> { };
            foreach (var blogType in Enum.GetValues(typeof(BlogType)))
            {
                blogTypes.Add(blogType.ToString());
            }

            var viewModel = new DevCreateViewModel
            {
                Title = "",
                Text = "",
                BlogTypes = blogTypes,
                SelectedBlogType = type,
                Categories = new List<string>()
            };

            if (id != "")
            {
                try
                {
                    BlogPost currentBlogPost = _blogPost.Where(blog => blog.Id == Guid.Parse(id)).FirstOrDefault();

                    viewModel.Title = currentBlogPost.Title;
                    viewModel.Text = currentBlogPost.Text;
                    viewModel.SelectedBlogType = currentBlogPost.BlogType.ToString();
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> Create(DevCreateViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = await _userManager.GetUserAsync(User);
                List<Person> listOfPersons = _person.GetUserBySubscription();

                BlogType blogType = (BlogType)Enum.Parse(typeof(BlogType), model.SelectedBlogType);

                
                var files = new List<FileUpload>();

                if (model.FileUploads != null)
                {
                    foreach (var file in model.FileUploads)
                    {
                        var fileUrl = UploadImage(file);
                        files.Add(new FileUpload
                        {
                            Url = fileUrl,
                            FileType = Path.GetExtension(fileUrl)

                        });
                    }
                }

                BlogPost blogPost = new()
                {
                    Id = Guid.NewGuid(),
                    Author = user,
                    Title = model.Title,
                    Text = model.Text,
                    DateEdited = DateTime.Now,
                    DatePublished = DateTime.Now,
                    BlogType = blogType,
                    Categories = await GetAndCreateCategories(blogType, model.Categories),
                    Files = files
                };

                var post = _blogPost.Where(x => x.Id == model.Id).FirstOrDefault();

                if (post != null && post.Files != null)
                {
                    files.AddRange(post.Files);
                }

                if (post == null)
                {
                    await _blogPost.Add(blogPost);
                    await _blogPost.Save();

                    string mailBody = $"Ett inlägg har skapats i bloggen av <b>{blogPost.Author.Name}</b>" +
                                      $"Rubrik: <b>{blogPost.Title.ToString()}</b><br />" +
                                      $"Text: <br />" +
                                      $"{blogPost.Text.ToString()}<br /><br />" +
                                      $"Läs inlägget här: <a href=\"https://localhost:44351/BlogPosts/Details/{blogPost.Id}\">{blogPost.Title.ToString()}</a>";

                    //_mail.SendMail(listOfPersons, $"{blogPost.Author.Name} har skapat ett inlägg", mailBody);
                    return RedirectToAction("Index", new { type = blogType });
                }

                post.DateEdited = DateTime.Now;
                post.Title = model.Title;
                post.Text = model.Text;
                post.BlogType = (BlogType)Enum.Parse(typeof(BlogType), model.SelectedBlogType);
                post.Files = files;

                await _blogPost.Save();
                return RedirectToAction("Index", new { type = blogType });
            }

            return View(model);
        }

        public async Task<List<Category>> GetAndCreateCategories(BlogType blogType, List<string> categoryNames)
        {
            if (categoryNames == null || !categoryNames.Any())
                return new List<Category>();

            var categories = _category
                .Where(c => c.Type == blogType && categoryNames.Contains(c.Name))
                .ToList();

            var missingCategories = categoryNames.Where(n => !categories.Any(c => c.Name == n));
            var currentUser = await _userManager.GetUserAsync(User);

            foreach (var categoryName in missingCategories)
            {
                var category = new Category
                {
                    Id = Guid.NewGuid(),
                    Name = categoryName,
                    Type = blogType,
                    Creator = currentUser,
                    Participants = new List<Person>()
                };

                currentUser.Subscriber = true;
                await _category.Add(category);
                await _category.Save();

                categories.Add(category);
            }

            return categories;
        }

        private string UploadImage(IFormFile file)
        {

            var uniqueFileName = GetUniqueFileName(file.FileName);
            var uploads = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
            var filePath = Path.Combine(uploads, uniqueFileName);
            file.CopyTo(new FileStream(filePath, FileMode.Create));

            return uniqueFileName;
        }

        private static string GetUniqueFileName(string fileName)
        {

            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_"
                   + Guid.NewGuid().ToString().Substring(0, 4)
                   + Path.GetExtension(fileName);
        }

        [HttpGet]
        public async Task<IActionResult> Remove(string id)
        {
            BlogPost currentBlogPost = _blogPost.Where(blog => blog.Id == Guid.Parse(id)).Include(b => b.Files).FirstOrDefault();

            if (currentBlogPost != null)
            {
                _blogPost.Remove(currentBlogPost);
                await _blogPost.Save();
            }

            return RedirectToAction("Index", new { type = currentBlogPost.BlogType});
        }
    }
}