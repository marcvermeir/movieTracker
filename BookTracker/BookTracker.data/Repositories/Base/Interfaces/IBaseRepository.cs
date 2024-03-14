﻿using System.Linq.Expressions;

namespace BookTracker.data.Repositories.Base.Interfaces
{
    /// <summary>
    /// Base Repository Interface.
    /// </summary>
    /// <typeparam name="T">The Type of Entity to operate on</typeparam>
    public interface IBaseRepository<T> where T : class
    {
        #region Methods

        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteManyAsync(Expression<Func<T, bool>> filter);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>>? filter = null,
                                          Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                          int? top = null,
                                          int? skip = null,
                                          params string[] includeProperties);

        #endregion
    }
}