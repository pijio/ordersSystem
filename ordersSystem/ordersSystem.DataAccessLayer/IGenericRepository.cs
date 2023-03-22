﻿using System.Linq.Expressions;
using ordersSystem.DomainModels;

namespace ordersSystem.DataAccessLayer;

public interface IGenericRepository<TEntity>
    where TEntity : class, IBaseEntity
{
    IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression = null);

    void Add(TEntity entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);

    IQueryable<TEntity> GetAll();

    Task<TEntity?> FirstOrDefaultAsync();

    Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression);

    void AddRange(IEnumerable<TEntity> entities);

    void DeleteRange(IEnumerable<TEntity> entities);

    Task AddAsync(TEntity entity);

    Task AddRangeAsync(IEnumerable<TEntity> entities);
        
    Task<IQueryable<TEntity>> GetAllAsync();

    bool Any(Expression<Func<TEntity, bool>> expression = null);
}