using System.Collections.Concurrent;
using Microsoft.EntityFrameworkCore;
using ordersSystem.DomainModels;

namespace ordersSystem.DataAccessLayer;

public class UnitOfWork<TContext> : IUnitOfWork<TContext>, IDisposable where TContext : DbContext
{
    protected readonly ConcurrentDictionary<Type, object> RepsDictionary;
    protected readonly TContext DbContext;

    protected UnitOfWork(TContext dbContext)
    {
        DbContext = dbContext;
        RepsDictionary = new ConcurrentDictionary<Type, object>();
    }

    public IGenericRepository<TEntity>? GetGenericRepository<TEntity>()
        where TEntity : class, IBaseEntity
    {
        return RepsDictionary.GetOrAdd(typeof(TEntity),
            x => new GenericRepository<TEntity>(DbContext))  as IGenericRepository<TEntity>;
    }
    public async Task SaveChangesAsync()
    {
        await DbContext.SaveChangesAsync();
    }
    
    #region IDisposable realization
    private bool _disposed;
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;

        if (disposing)
        {
            DbContext.Dispose();
        }
        _disposed = true;
    }

    ~UnitOfWork() => Dispose(false);
    #endregion
}