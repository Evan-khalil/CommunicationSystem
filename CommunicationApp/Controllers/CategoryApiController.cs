using CommunicationApp.Data;
using CommunicationApp.Models;
using CommunicationApp.Repository;
using CommunicationApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationApp.Controllers
{
    [Route("Api/Category/[action]")]
    [ApiController]
    public class CategoryApiController : ControllerBase
    {
        protected ApplicationDbContext _context { get; set; }
        private readonly ICategoryRepository _category;
        private readonly UserManager<Person> _userManager;
        private readonly IBlogPostRepository _blogPost;

        public CategoryApiController(ICategoryRepository categoryRepository, ApplicationDbContext context, IBlogPostRepository blogPostRepository, UserManager<Person> userManager)
        {
            _context = context;
            _category = categoryRepository;
            _userManager = userManager;
            _blogPost = blogPostRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult GetCategories(BlogType blogType)
        {
            var userId = _userManager.GetUserId(User);
            var isAdminUser = User.IsInRole("Admin");

            var categories = _category.GetCategoriesForParticipant(blogType, userId, isAdminUser);
            var categoryViewModels = categories.Select(c => new CategoryViewModel { Id = c.Id, Name = c.Name, Type = c.Type });

            return Ok(categoryViewModels);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetCategoryForPostAsync(string id)
        {
            List<Category> categoriesToReturn = new List<Category>();

            if (!string.IsNullOrEmpty(id))
            {
                var blogPosts = await _context.BlogPosts.Include(c => c.Categories).ToListAsync();
                BlogPost blogPost = blogPosts.FirstOrDefault(b => b.Id == System.Guid.Parse(id));

                if (blogPost is not null)
                    categoriesToReturn.AddRange(blogPost.Categories);
            }

            return Ok(categoriesToReturn);
        }
    }

    public class GetCategories
    {
        public BlogType Type { get; set; }
    }
}