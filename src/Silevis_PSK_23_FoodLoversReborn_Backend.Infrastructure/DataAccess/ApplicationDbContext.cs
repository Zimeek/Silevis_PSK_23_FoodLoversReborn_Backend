using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() {}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    /*
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server with connection string from app settings
        options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Silevis_PSK_23_FoodLoversReborn;Trusted_Connection=True;");
    }
    */
    
    
    
    public DbSet<Internship> Internships { get; set; }
    public DbSet<InternshipDelayRequest> InternshipDelayRequests { get; set; }
    public DbSet<StudentDocument> StudentDocuments { get; set; }
}