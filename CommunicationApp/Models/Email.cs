using System.ComponentModel.DataAnnotations;

namespace CommunicationApp.Models
{
    public class Email
    {
        [EmailAddress]
        [Display(Name = "Nuvarande E-post")]
        [Required(ErrorMessage = "Du måste fylla i din nuvarande mail")]
        public string OldEmail { get; set; }

        [EmailAddress]
        [Display(Name = "Ny E-post")]
        [Required(ErrorMessage = "Du måste fylla i din nya mailadress")]
        public string NewEmail { get; set; }
    }
}