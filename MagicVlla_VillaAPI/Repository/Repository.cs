﻿using MagicVlla_VillaAPI.Data;
using MagicVlla_VillaAPI.Models;
using MagicVlla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVlla_VillaAPI.Repository
{
    public class Repository <T>: IRepository<T> where T : class 
    {
        private readonly ApplicationDBContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDBContext db)
        {
            _db = db;
           // _db.VillaNumber.Include(u => u.Villa).ToList();
            this.dbSet=_db.Set<T>();



        }
        public async Task CreateAsync(T entry)
        {
            await dbSet.AddAsync(entry);
            await SaveAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if(includeProperties != null)
            {
                foreach(var prop in  includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query= query.Include(prop);
                }
            }
            return await query.FirstOrDefaultAsync();

        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var prop in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(prop);
                }
            }
            return await query.ToListAsync();

        }

        public async Task RemoveAsync(T entry)
        {
            dbSet.Remove(entry);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();

        }

        
    }
}
