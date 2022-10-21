using System.ComponentModel.DataAnnotations;

namespace CommunicationApp.Models
{
    public class FileUpload
    {
        [Key]
        public string Url { get; set; }
        public string FileType { get; set; }
    }
}
