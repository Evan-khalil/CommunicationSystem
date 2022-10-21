using CommunicationApp.Models;
using System.Collections.Generic;

namespace CommunicationApp.ViewModels
{
    public class CreateMeetingViewModel
    {
        public Meeting Meeting { get; set; }

        public List<Person> AllPersons { get; set; }
    }
}