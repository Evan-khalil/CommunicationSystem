using CommunicationApp.Data;
using CommunicationApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CommunicationApp.Repository
{
    public class BlogPostRepository : Repository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<BlogPost> Search(string searchCriteria, BlogType? blogType, bool searchTitleAndText, bool searchAuthor)
        {
            var query = _context.BlogPosts.AsQueryable();

            if (blogType.HasValue)
                query = query.Where(p => p.BlogType == blogType.Value);

            if (searchTitleAndText && searchAuthor)
            {
                query = query.Where(p => p.Title.Contains(searchCriteria) ||
                                         p.Text.Contains(searchCriteria) ||
                                         p.Author.UserName.Contains(searchCriteria) ||
                                         p.Author.FirstName.Contains(searchCriteria) ||
                                         p.Author.LastName.Contains(searchCriteria));
            }
            else
            {
                if (searchTitleAndText)
                    query = query.Where(p => p.Title.Contains(searchCriteria) || p.Text.Contains(searchCriteria));

                if (searchAuthor)
                    query = query.Where(p => p.Author.FirstName.Contains(searchCriteria) || p.Author.LastName.Contains(searchCriteria) || p.Author.UserName.Contains(searchCriteria));
            }

            return query
                .Include(p => p.Categories).ThenInclude(c => c.Creator)
                .Include(p => p.Categories).ThenInclude(c => c.Participants)
                .Include(p => p.Author);
        }
    }
}