namespace ordersSystem.DataAccessLayer;

public class PostgresUnitOfWork : UnitOfWork<PostgresContext>
{
    public PostgresUnitOfWork(PostgresContext dbContext) : base(dbContext)
    {
    }
}