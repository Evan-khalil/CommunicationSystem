using CommunicationApp.Models;
using System.Collections.Generic;

namespace CommunicationApp.Repository
{
    public interface IMailRepository
    {
        void SendMail(List<Person> ToList, string subject, string body) { }
    }
}