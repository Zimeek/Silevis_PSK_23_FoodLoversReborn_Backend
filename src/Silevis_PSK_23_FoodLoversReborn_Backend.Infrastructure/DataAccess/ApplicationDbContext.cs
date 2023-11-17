using Microsoft.EntityFrameworkCore;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }
}