using CommunicationApp.Models;
using System.Collections.Generic;

namespace CommunicationApp.ViewModels
{
    public class MyMeetingsViewModel
    {
        public List<Meeting> MeetingsToConfirm { get; set; }

        public List<Meeting> PendingHostConfirm { get; set; }
    }
}