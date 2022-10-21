using CommunicationApp.Data;
using CommunicationApp.Models;
using CommunicationApp.Repository;
using CommunicationApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CommunicationApp.Controllers
{
    [Authorize]
    public class BlogPostsController : Controller
    {
        protected ApplicationDbContext _context { get; set; }
        private readonly UserManager<Person> _userManager;
        private readonly ICategoryRepository _category;
        private readonly IPersonRepository _person;
        private readonly IMailRepository _mail;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogPostsController(UserManager<Person> userManager, ApplicationDbContext context, ICategoryRepository categoryRepository, 
                                   IPersonRepository personRepository, IWebHostEnvironment webHostEnvironment, IMailRepository mailRepository)
        {
            _context = context;
            _userManager = userManager;
            _category = categoryRepository;
            _person = personRepository;
            _webHostEnvironment = webHostEnvironment;
            _mail = mailRepository;
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

            var bloggensTyp = new BlogType();

            if (type is not null && type == "Informal")
            {
                ViewData["Title"] = "Informell";
                bloggensTyp = BlogType.Informal;
            }
            else
            {
                ViewData["Title"] = "Formell";
                bloggensTyp = BlogType.Formal;
            }

            var blogPosts = await _context.BlogPosts
                            .Where(b => b.BlogType == bloggensTyp)
                            .Where(b => isAdminUser || b.Author.Id == userId || b.Categories.Any(c => c.Creator.Id == userId || !c.Participants.Any() || c.Participants.Any(p => p.Id == userId)))
                            .Include(c => c.Categories)
                            .Include(b => b.Files)
                            .Include(a => a.Author)
                            .Include(c => c.Comments)
                            .ThenInclude(c => c.Author)
                            .OrderByDescending(b => b.DateEdited)
                            .ToListAsync();

            var viewModel = new BlogPostsViewModel
            {
                BlogPosts = blogPosts.Skip(((int)sida - 1) * pageSize).Take(pageSize).ToList(),
                CurrentPage = (int)sida,
                TotalPages = (int)Math.Ceiling(blogPosts.Count / (decimal)pageSize),
                CurrentUrl = "/BlogPosts?type=" + type,
                TotalPosts = blogPosts.Count
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var blogPost = await _context.BlogPosts
                .Include(c => c.Categories)
                .Include(b => b.Files)
                .Include(a => a.Author)
                .Include(b => b.Comments)
                .ThenInclude(c => c.Author)
                .SingleOrDefaultAsync(b => b.Id == id);

            return View(blogPost);
        }


        // GET: /BlogPosts/SetBlogPost
        [HttpGet]
        public IActionResult SetBlogPost(string id, string type)
        {
            var blogTypes = new List<string> { };
            foreach (var blogType in Enum.GetValues(typeof(BlogType)))
            {
                blogTypes.Add(blogType.ToString());
            }

            var viewModel = new SetBlogPostViewModel
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
                    BlogPost currentBlogPost = _context.BlogPosts.Where(blog => blog.Id == Guid.Parse(id)).FirstOrDefault();

                    viewModel.Title = currentBlogPost.Title;
                    viewModel.Text = currentBlogPost.Text;
                    viewModel.SelectedBlogType = currentBlogPost.BlogType.ToString();
                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return View(viewModel);
        }

        // POST: /BlogPosts/SetBlogPost
        [HttpPost]
        public async Task<ActionResult> SetBlogPost(SetBlogPostViewModel setBlogPostViewModel)
        {
            if (ModelState.IsValid)
            {

                var user = await _userManager.GetUserAsync(User);
                List<Person> listOfPersons = _person.GetUserBySubscription();

                BlogType blogType = (BlogType) Enum.Parse(typeof(BlogType), setBlogPostViewModel.SelectedBlogType);

                //to do, ladda in lista om lista finns (för edit).
                var files = new List<FileUpload>();

                if (setBlogPostViewModel.FileUploads != null)
                {
                    foreach (var file in setBlogPostViewModel.FileUploads)
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
                    Title = setBlogPostViewModel.Title,
                    Text = setBlogPostViewModel.Text,
                    DateEdited = DateTime.Now,
                    DatePublished = DateTime.Now,
                    BlogType = blogType,
                    Categories = await GetAndCreateCategories(blogType, setBlogPostViewModel.Categories),
                    Files = files
                };

                var post = _context.BlogPosts.Where(x => x.Id == setBlogPostViewModel.Id).FirstOrDefault();

                if (post == null)
                {
                    _context.BlogPosts.Add(blogPost);
                    await _context.SaveChangesAsync();

                    string mailBody = $"Ett inlägg har skapats i bloggen av <b>{blogPost.Author.Name}</b>" +
                                      $"Rubrik: <b>{blogPost.Title.ToString()}</b><br />" +
                                      $"Text: <br />"+
                                      $"{blogPost.Text.ToString()}<br /><br />" +
                                      $"Läs inlägget här: <a href=\"https://localhost:44351/BlogPosts/Details/{blogPost.Id}\">{blogPost.Title.ToString()}</a>";

                    //_mail.SendMail(listOfPersons, $"{blogPost.Author.Name} har skapat ett inlägg", mailBody);
                    return RedirectRelevantBlogType(blogPost.BlogType);
                }

                post.DateEdited = DateTime.Now;
                post.Title = setBlogPostViewModel.Title;
                post.Text = setBlogPostViewModel.Text;
                post.BlogType = (BlogType) Enum.Parse(typeof(BlogType), setBlogPostViewModel.SelectedBlogType);

                // remove post from other categories
                foreach (var mainCategory in _context.Categories.Include(d => d.BlogPosts))
                {
                    mainCategory.BlogPosts.Remove(post);
                    _context.Categories.Update(mainCategory);
                }

                foreach (var cat in setBlogPostViewModel.Categories)
                {
                    Category parentCat = _context.Categories
                        .Include(b => b.BlogPosts)
                        .FirstOrDefault(c => c.Name == cat.ToString());
                    parentCat.BlogPosts.Remove(post);

                    _context.SaveChanges();
                }

                post.Categories = await GetAndCreateCategories(blogType, setBlogPostViewModel.Categories);

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { type = setBlogPostViewModel.SelectedBlogType });
            }

            return View(setBlogPostViewModel);
        }

        // POST: /BlogPosts/DeleteBlogPost
        [HttpGet]
        public async Task<IActionResult> RemoveBlogPost(string id)
        {
            BlogPost currentBlogPost = _context.BlogPosts.Where(blog => blog.Id == Guid.Parse(id)).Include(b => b.Files).FirstOrDefault();

            if (currentBlogPost != null)
            {
                _context.BlogPosts.Remove(currentBlogPost);
                await _context.SaveChangesAsync();
            }

            return RedirectRelevantBlogType(currentBlogPost.BlogType);
        }

        private RedirectToActionResult RedirectRelevantBlogType(BlogType blogType)
        {
            return RedirectToAction("Index", new { type = blogType });
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
    }
}
