using CommunicationApp.Models;
using System.Collections.Generic;

namespace CommunicationApp.ViewModels
{
    public class DeleteUserViewModel
    {
        public List<Person> Persons { get; set; }
        public Person Person { get; set; }
    }
}