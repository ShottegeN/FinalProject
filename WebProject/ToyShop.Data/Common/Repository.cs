using Microsoft.EntityFrameworkCore;

namespace ToyShop.Data.Common
{
    public class Repository : IRepository
    {
        protected DbContext Context;

        public Repository(ToyShopDbContext dbContext)
        {
            Context = dbContext;
        }

        protected DbSet<T> DbSet<T>() where T : class
        {
            return Context.Set<T>();
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public async Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class
        {
            await DbSet<T>().AddRangeAsync(entities);
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        public IQueryable<T> AllReadonlyAsync<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }

        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }

        public Task UpdateAsync<T>(T entity) where T : class
        {
            DbSet<T>().Update(entity);
            return Task.CompletedTask;
        }

        public async Task RemoveByIdAsync<T>(object id) where T : class
        {
            var entity = await GetByIdAsync<T>(id);
            if (entity != null)
            {
                DbSet<T>().Remove(entity);
            }
        }

        public Task RemoveAsync<T>(T entity) where T : class
        {
            DbSet<T>().Remove(entity);
            return Task.CompletedTask;
        }

        public Task RemoveRangeAsync<T>(IEnumerable<T> entities) where T : class
        {
            DbSet<T>().RemoveRange(entities);
            return Task.CompletedTask;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
