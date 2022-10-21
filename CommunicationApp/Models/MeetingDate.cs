using System;
using System.Collections.Generic;

namespace CommunicationApp.Models
{
    public class MeetingDate
    {
        public Guid Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<Person> Attendees { get; set; }
    }
}