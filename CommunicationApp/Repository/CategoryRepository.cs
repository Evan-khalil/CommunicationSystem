using CommunicationApp.Data;
using CommunicationApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommunicationApp.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Category FindById(Guid id)
        {
            return _context.Categories
                .Where(c => c.Id == id)
                .Include(c => c.Creator)
                .Include(c => c.Participants)
                .FirstOrDefault();
        }

        public bool HasBlogPosts(Category category)
        {
            return _context.Entry(category)
                .Collection(c => c.BlogPosts)
                .Query()
                .Any();
        }

        public IEnumerable<Category> Search(string searchCriteria)
        {
            return _context.Categories
                .Where(c => c.Name.Contains(searchCriteria))
                .Include(c => c.BlogPosts)
                .ThenInclude(b => b.Author)
                .Include(c => c.Participants);
        }

        public IEnumerable<Category> GetCategoriesForParticipant(BlogType? blogType, string userId, bool isAdminUser)
        {
            return _context.Categories
                .Where(c => (!blogType.HasValue || c.Type == blogType) && 
                            (isAdminUser || c.Creator.Id == userId || !c.Participants.Any() || c.Participants.Any(p => p.Id == userId)))
                .Include(c => c.Creator);
        }
    }
}