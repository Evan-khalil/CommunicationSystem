using CommunicationApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunicationApp.ViewModels
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Kategorinamn måste anges.")]
        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Display(Name = "Typ")]
        public BlogType Type { get; set; }

        public string ErrorMessage { get; set; }

        public Person Creator { get; set; }

        public List<Person> Participants { get; set; }
    }
}