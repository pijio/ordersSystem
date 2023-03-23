using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ordersSystem.DomainModels;

namespace ordersSystem.DataAccessLayer;

public class PostgresContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Provider> Providers { get; set; }
    public PostgresContext(DbContextOptions<PostgresContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        MapKeys(builder);
        
        base.OnModelCreating(builder);
    }

    private void MapKeys(ModelBuilder builder)
    {
        // FK Order-OrderItem
        builder.Entity<OrderItem>()
            .HasOne(o => o.Order)
            .WithMany(oi => oi.OrderItems)
            .HasForeignKey(oi => oi.OrderId);
    }
}