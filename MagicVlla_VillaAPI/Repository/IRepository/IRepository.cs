using MagicVlla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVlla_VillaAPI.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>?  filter = null, string? includeProperties=null);
        Task<T> GetAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true, string? includeProperties = null);
        Task CreateAsync(T entry);   
      
        Task RemoveAsync(T entry);
        Task SaveAsync();
    }
}
