using MagicVlla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVlla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        //Task<List<Villa>> GetAllAsync(Expression<Func<Villa,bool>>filter = null);
        //Task <Villa> GetAsync(Expression<Func<Villa,bool>>filter = null,bool tracked=true);
        //Task CreateAsync(Villa entry);
        Task<Villa> UpdateAsync(Villa entry);
        //Task RemoveAsync(Villa entry);
        //Task SaveAsync();
    }
}
