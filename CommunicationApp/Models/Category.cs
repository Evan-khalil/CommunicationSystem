using System;
using System.Collections.Generic;
using System.Linq;

namespace CommunicationApp.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BlogType Type { get; set; }
        public virtual List<BlogPost> BlogPosts { get; set; }
        public Person Creator { get; set; }
        public List<Person> Participants { get; set; }

        public bool HasReadAccess(string userId, bool isAdminUser)
        {
            if (isAdminUser)
                return true;

            if (Creator != null && Creator.Id == userId)
                return true;

            if (Participants != null && !Participants.Any())
                return true;

            if (Participants != null && Participants.Any(p => p.Id == userId))
                return true;

            return false;
        }

        public bool HasWriteAccess(string userId, bool isAdminUser)
        {
            if (isAdminUser)
                return true;

            if (Creator != null && Creator.Id == userId)
                return true;

            return false;
        }
    }
}
