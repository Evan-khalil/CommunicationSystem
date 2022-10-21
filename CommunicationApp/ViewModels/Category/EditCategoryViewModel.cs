using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunicationApp.ViewModels
{
    public class EditCategoryViewModel
    {
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Kategorinamn måste anges.")]
        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Display(Name = "Deltagare (En tom lista betyder alla kan se kategorin)")]
        public List<SelectListItem> Participants { set; get; }

        public string[] ParticipantIds { get; set; }

        [Display(Name = "Användare")]
        public List<SelectListItem> AllUsers { set; get; }

        public string UserId { get; set; }

        public string ErrorMessage { get; set; }
    }
}