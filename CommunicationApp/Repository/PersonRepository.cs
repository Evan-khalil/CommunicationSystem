using CommunicationApp.Data;
using CommunicationApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationApp.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationDbContext identityContext) : base(identityContext)
        {

        }

        public async Task<Person> GetById(string id)
        {
            return await _context.Persons.FindAsync(id);
        }

        public async Task<Person> GetByUserName(string userName)
        {
            return await _context.Persons.FirstOrDefaultAsync(p => p.UserName.Equals(userName));
        }

        public string GetNameById(string id)
        {
            Person person = _context.Persons.FirstOrDefault(p => p.Id.Equals(id));

            return person.FirstName + " " + person.LastName;
        }

        public List<Person> GetUserBySubscription()
        {
           return _context.Persons
                .Where(p => p.Subscriber.Equals(true))
                .ToList();

        }
    }
}