using CommunicationApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunicationApp.ViewModels
{
    public class BlogPostsViewModel
    {
        [Required]
        public List<BlogPost> BlogPosts { get; set; }

        public string NoBlogPostsMessage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public string CurrentUrl { get; set; }

        public int TotalPosts { get; set; }

        public bool IsSearchResult { get; set; }
    }
}