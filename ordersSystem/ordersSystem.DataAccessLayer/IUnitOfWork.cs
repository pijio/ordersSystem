using Microsoft.EntityFrameworkCore;
using ordersSystem.DomainModels;

namespace ordersSystem.DataAccessLayer;

public interface IUnitOfWork
{
    public IGenericRepository<TEntity>? GetGenericRepository<TEntity>() where TEntity : class, IBaseEntity;
    public Task SaveChangesAsync();
}