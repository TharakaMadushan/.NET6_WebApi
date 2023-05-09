namespace WebApi.Helpers;

using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

public class DataContext : DbContext
{
    //protected readonly IConfiguration Configuration;

    //public DataContext(IConfiguration configuration)
    //{
    //    Configuration = configuration;
    //}

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<User> tblRefUser { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(o => o.Id);
    }

    public DbSet<User> Users { get; set; }
}