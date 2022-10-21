using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunicationApp.ViewModels
{
    public class SetBlogPostViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Ange titel")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Skriv in din text")]
        [DataType(DataType.Text)]
        public string Text { get; set; }

        [Display(Name = "Blogg-typ")]
        public List<string> BlogTypes { get; set; }

        [Required]
        public string SelectedBlogType { get; set; }

        [Display(Name = "Ny kategori")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string NewCategory { get; set; }

        [Required]
        [Display(Name = "Kategorier")]
        public List<string> Categories { get; set; } = new List<string>();

        [AllowedExtensions(new string[]
            {".jpg", ".jpeg", ".png", ".gif", ".doc", ".docx", ".ppt", ".xlsx", ".pdf", ".zip", ".rar"})]
        public List<IFormFile> FileUploads { get; set; }
    }
}