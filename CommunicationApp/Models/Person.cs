using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunicationApp.Models
{
    public class Person : IdentityUser
    {
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }
        [Display(Name = "Efternamn")]
        public string LastName { get; set; }
        
        public bool Subscriber { get; set; }
        public List<Meeting> HostMeetings { get; set; }
        public List<Meeting> MeetingRequests { get; set; }
        public List<MeetingDate> MeetingDateRequests { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Category> CategoryCreations { get; set; }
        public List<Category> CategoryAccessList { get; set; }
        public List<Meeting> NotAttending { get; set; }
        public bool IsDeleted { get; set; }

        [NotMapped]
        public string Name => $"{FirstName} {LastName}".Trim(); //Förnamn Efternamn

        [NotMapped]
        public string FullUserName => $"{Name} ({UserName})".Trim(); //Förnamn Efternamn (Användarnamn)

        public Person()
        {
            Subscriber = true;
        }
    }
}