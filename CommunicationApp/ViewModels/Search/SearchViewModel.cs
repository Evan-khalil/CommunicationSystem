using CommunicationApp.Models;
using System.ComponentModel.DataAnnotations;

namespace CommunicationApp.ViewModels
{
    public class SearchViewModel
    {
        [Display(Name = "Sök poster som matchar titel, text, kategori eller användare.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Sökvillkor måste anges.")]
        public string SearchCriteria { get; set; }

        [Display(Name = "Blogtyp")]
        public BlogType? Type { get; set; }

        [Display(Name = "Titel och text")]
        public bool SearchTitleAndText { get; set; }

        [Display(Name = "Användare")]
        public bool SearchAuthor { get; set; }

        [Display(Name = "Kategori")]
        public bool SearchCategories { get; set; }
    }
}