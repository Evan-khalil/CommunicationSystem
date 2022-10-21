using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CommunicationApp.Repository
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        void Remove(T entity);
        void Remove(Guid id);
        void RemoveRange(List<T> entitiesToRemove);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Save();
    }
}