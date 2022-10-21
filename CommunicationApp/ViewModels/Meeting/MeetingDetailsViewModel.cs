using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunicationApp.Models;

namespace CommunicationApp.ViewModels
{
    public class MeetingDetailsViewModel
    {
        public string Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public Person Host { get; set; }
        public List<Person> Attendees { get; set; }
    }
}