using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunicationApp.Models
{
    public class Meeting
    {
        public Guid Id { get; set; }

        [Display(Name = "Rubrik")]
        public string Subject { get; set; }

        [Display(Name = "Beskrivning")]
        public string Description { get; set; }
        public MeetingDate FinalDate { get; set; }
        public List<MeetingDate> DateRequests { get; set; }
        public List<Person> Recipients { get; set; }
        public Person Host { get; set; }
        public List<Person> NonAttenders { get; set;  }
    }
}
