using Microsoft.EntityFrameworkCore;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

public static class ApplicationDbContextSeeder
{
    public static async Task SeedAsync(ApplicationDbContext dbContext)
    {
        if (dbContext.Database.IsSqlServer())
        {
            await dbContext.Database.MigrateAsync();
        }

        if (!dbContext.Internships.Any())
        {
            var internship_1 = new Internship(36292);
            internship_1.SetDetails(
                "TechInnovate Solutions Sp. z o.o.",
                "ul. Kwiatowa 123, Warszawa",
                "123 456 789",
                DateTime.Parse("Jan 1, 2023"),
                DateTime.Parse("Feb 1, 2023"),
                1
                );
            
            var internship_2 = new Internship(36293);
            internship_2.SetDetails(
                "CreativeBytes Interactive Studio LLC",
                "ul. Leśna 789, Gdańsk",
                null,
                DateTime.Parse("Sep 1, 2023"),
                DateTime.Parse("Oct 1, 2023"),
                1
            );
            
            var internships = new List<Internship>
            {
                internship_1,
                internship_2
            };

            await dbContext.AddRangeAsync(internships);
        }

        await dbContext.SaveChangesAsync();
    }
}