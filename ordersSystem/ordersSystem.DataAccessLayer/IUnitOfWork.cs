using Microsoft.EntityFrameworkCore;
using ordersSystem.DomainModels;

namespace ordersSystem.DataAccessLayer;

public interface IUnitOfWork<TContext> where TContext : DbContext
{
    public IGenericRepository<TEntity>? GetGenericRepository<TEntity>() where TEntity : class, IBaseEntity;
    public Task SaveChangesAsync();
}