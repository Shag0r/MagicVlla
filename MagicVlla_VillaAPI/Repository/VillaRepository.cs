using MagicVlla_VillaAPI.Data;
using MagicVlla_VillaAPI.Models;
using MagicVlla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVlla_VillaAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDBContext _db;

        public VillaRepository(ApplicationDBContext db) :base(db){
            _db = db;

        
        
        }


        public async Task<Villa> UpdateAsync(Villa entry)
        {
            entry.UpdatedDate = DateTime.Now;
           _db.Villas.Update(entry);
            await _db.SaveChangesAsync();
            return entry;
        }
    }
}

