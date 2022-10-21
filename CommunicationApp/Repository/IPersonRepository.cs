using CommunicationApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationApp.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        string GetNameById(string id);
        Task<Person> GetByUserName(string userName);
        Task<Person> GetById(string id);
        List<Person> GetUserBySubscription();
    }
}