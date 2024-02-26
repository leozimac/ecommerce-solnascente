using EcommerceAPI.Features.Orders;
using EcommerceAPI.Features.Users.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.IoC;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    #region DbSets

    public DbSet<User> Users { get; set; }
    //public DbSet<Order> Orders { get; set; }

    #endregion
}
