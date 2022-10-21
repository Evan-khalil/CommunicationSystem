using CommunicationApp.Models;
using CommunicationApp.Repository;
using CommunicationApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommunicationApp.Controllers
{
    public class SearchController : Controller
    {
        private readonly IBlogPostRepository _blogPost;
        private readonly ICategoryRepository _category;
        private readonly UserManager<Person> _userManager;

        public SearchController(IBlogPostRepository blogPostRepository, ICategoryRepository categoryRepository, UserManager<Person> userManager)
        {
            _blogPost = blogPostRepository;
            _category = categoryRepository;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var blogTypes = new List<string> { };
            foreach (var blogType in Enum.GetValues(typeof(BlogType)))
            {
                blogTypes.Add(blogType.ToString());
            }

            var searchViewModel = new SearchViewModel
            { 
                SearchTitleAndText = true,
                SearchAuthor = true,
                SearchCategories = true,
                Type = null
            };

            return View("Search", searchViewModel);
        }

        [HttpGet]
        public IActionResult Search(string searchCriteria, BlogType? blogType, bool searchTitleAndText, bool searchAuthor, bool searchCategories)
        {
            var userId = _userManager.GetUserId(User);
            bool isAdminUser = User.IsInRole("Admin");

            var blogPosts = searchTitleAndText || searchAuthor 
                ? SearchBlogPosts(searchCriteria, blogType, searchTitleAndText, searchAuthor)
                : new List<BlogPost>();

            var categoryPosts = searchCategories ? SearchCategories(searchCriteria, blogType) : new List<BlogPost>();

            var searchResult = blogPosts
                .Union(categoryPosts)
                .Where(b => b.Categories.Any(c => c.HasReadAccess(userId, isAdminUser)))
                .Distinct()
                .ToList();

            searchResult.ForEach(b => b.Files = new List<FileUpload>());

            if (blogType == null || blogType == BlogType.Formal || blogType == BlogType.Informal)
            {
                var searchResultViewModel = new BlogPostsViewModel
                {
                    BlogPosts = searchResult,
                    NoBlogPostsMessage = !searchResult.Any() ? "Inga blogposter matchade sökvillkoren." : null,
                    IsSearchResult = true
                };

                return PartialView("~/Views/BlogPosts/_PostsPartial.cshtml", searchResultViewModel);
            }
            else
            {
                var searchResultViewModel = new DevelopmentViewModel
                {
                    BlogPosts = searchResult,
                    NoBlogPostsMessage = !searchResult.Any() ? "Inga blogposter matchade sökvillkoren." : null,
                    IsSearchResult = true
                };

                return PartialView("~/Views/Development/_PostsPartial.cshtml", searchResultViewModel);
            }
        }

        private IEnumerable<BlogPost> SearchBlogPosts(string searchCriteria, BlogType? blogType, bool searchTitleAndText, bool searchAuthor)
        {
            return _blogPost.Search(searchCriteria, blogType, searchTitleAndText, searchAuthor);
        }

        private IEnumerable<BlogPost> SearchCategories(string searchCriteria, BlogType? blogType)
        {
            return _category.Search(searchCriteria) 
                .SelectMany(c => c.BlogPosts) 
                .Where(p => blogType == null || p.BlogType == blogType.Value)
                .Distinct(); 
        }
    }
}