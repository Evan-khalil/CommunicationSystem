using CommunicationApp.Models;
using System;
using System.Collections.Generic;

namespace CommunicationApp.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category FindById(Guid id);
        bool HasBlogPosts(Category category);
        IEnumerable<Category> Search(string searchCriteria);
        IEnumerable<Category> GetCategoriesForParticipant(BlogType? blogType, string userId, bool isAdminUser);
    }
}