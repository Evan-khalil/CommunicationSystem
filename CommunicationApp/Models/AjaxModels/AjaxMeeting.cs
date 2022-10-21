using System;
using System.Collections.Generic;

namespace CommunicationApp.Models.AjaxModels
{
    public class AjaxMeeting
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<AjaxMeetingDate> MeetingDates { get; set; }
        public List<string> MeetingPersons { get; set; }
    }

    public class AjaxMeetingDate
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class AjaxCalendarMeeting
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public AjaxCalendarMeetingPerson Host { get; set; }
        public List<AjaxCalendarMeetingPerson> Participants { get; set; }

    }

    public class AjaxDeleteCalendarMeeting
    {
        public string Id { get; set; }
    }

    public class AjaxCalendarMeetingPerson
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
  
    public class AjaxMeetingAccept
    {
        public List<string> AcceptedMeetingDates { get; set; }
        public string DeclinedMeeting { get; set; }
    }

    public class AjaxMeetingConfirm
    {
        public string FinalMeetingDate { get; set; }
    }
}