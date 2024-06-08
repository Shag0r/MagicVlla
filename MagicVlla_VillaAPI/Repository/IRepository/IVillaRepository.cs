using MagicVlla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVlla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
      
        Task<Villa> UpdateAsync(Villa entry);
       
    }
}
