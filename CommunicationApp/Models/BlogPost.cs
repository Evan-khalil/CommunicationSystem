using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunicationApp.Models
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime DateEdited { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Person Author { get; set; }
        public List<Category> Categories { get; set; }
        public BlogType BlogType { get; set; }
        public List<Comment> Comments { get; set; }
        public List<FileUpload> Files { get; set; }

        public string GetExcerpt()
        {
            if (string.IsNullOrEmpty(Text))
                return string.Empty;

            var excerptLength = Math.Min(Text.Length, 150);
            var excerpt = Text.Substring(0, excerptLength);
            if (excerpt.Length == 150)
                excerpt += "...";

            return excerpt;
        }
    }

    public enum BlogType
    {
        [Display(Name = "Informell")]
        Informal,
        [Display(Name = "Formell")]
        Formal,

        [Display(Name = "Utbildning")]
        Education,
        [Display(Name = "Forskning")]
        Research
    }
}
