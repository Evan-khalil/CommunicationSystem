using System;

namespace CommunicationApp.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public Person Author { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
