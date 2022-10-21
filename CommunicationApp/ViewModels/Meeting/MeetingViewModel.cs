using CommunicationApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunicationApp.ViewModels
{
    public class MeetingViewModel
    {
        public Meeting Meeting { get; set; }

        [Required(ErrorMessage = "Du behöver välja minst en person att bjuda in till mötet")]
        public List<string> SelectedPersons { get; set; }
        public IEnumerable<SelectListItem> AllPersons { get; set; }

        public List<string> SelectedDates { get; set; }
        public IEnumerable<SelectListItem> AllDates { get; set; }

        public MeetingDate MeetingDate { get; set; }
    }
}