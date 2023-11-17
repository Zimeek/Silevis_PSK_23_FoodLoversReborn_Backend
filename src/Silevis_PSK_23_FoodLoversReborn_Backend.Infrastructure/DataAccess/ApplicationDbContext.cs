using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    
    public DbSet<Internship> Internships { get; set; }
}