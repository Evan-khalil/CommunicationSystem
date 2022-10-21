using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationApp.Models.AjaxModels
{
    public class AjaxComment
    {
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public Guid BlogPost { get; set; }
    }
    public class AjaxCommentReturn
    {
        public Guid CommentId { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
        public string Email { get; set; }
    }
}
