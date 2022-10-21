using CommunicationApp.Models;
using System.Collections.Generic;

namespace CommunicationApp.Repository
{
    public interface IBlogPostRepository : IRepository<BlogPost>
    {
        IEnumerable<BlogPost> Search(string searchCriteria, BlogType? blogType, bool searchTitleAndText, bool searchAuthor);
    }
}