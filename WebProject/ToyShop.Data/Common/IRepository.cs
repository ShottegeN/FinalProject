﻿namespace ToyShop.Data.Common
{
    public interface IRepository : IDisposable
    {
        IQueryable<T> All<T>() where T : class;
        IQueryable<T> AllReadonlyAsync<T>() where T : class;
        Task<T?> GetByIdAsync<T>(object id) where T : class;
        Task AddAsync<T>(T entity) where T : class;
        Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class;
        Task UpdateAsync<T>(T entity) where T : class;
        Task RemoveByIdAsync<T>(object id) where T : class;
        Task RemoveAsync<T>(T entity) where T : class;
        Task RemoveRangeAsync<T>(IEnumerable<T> entities) where T : class;
        Task<int> SaveChangesAsync();
    }
}
