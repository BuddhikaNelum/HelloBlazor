using HelloBlazor.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloBlazor.Services
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly BlazorDbContext blazorDbContext;
        private DbSet<TEntity> entity;

        public Repository(BlazorDbContext blazorDbContext)
        {
            this.blazorDbContext = blazorDbContext;
            entity = blazorDbContext.Set<TEntity>();

        }

        public async Task<bool> AddAsync(TEntity obj)
        {
            try
            {
                await entity.AddAsync(obj);

                if (await blazorDbContext.SaveChangesAsync() > 0) { return true; } return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            try
            {
                return await entity.ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
