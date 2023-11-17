using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.EntityConfigurations;

public class InternshipConfiguration : IEntityTypeConfiguration<Internship>
{
    public void Configure(EntityTypeBuilder<Internship> builder)
    {
        builder.HasKey(x => x.Id);
        builder.OwnsOne(
            x => x.InternshipDetails,
            x =>
            {
                x.Property(p => p.CompanyName).HasColumnName("CompanyName");
                x.Property(p => p.CompanyAddress).HasColumnName("CompanyAddress");
                x.Property(p => p.CompanyPhone).HasColumnName("CompanyPhone");
                x.Property(p => p.DateStart).HasColumnName("DateStart");
                x.Property(p => p.DateEnd).HasColumnName("DateEnd");
                x.Property(p => p.Month).HasColumnName("Month");
            }
        ).ToTable("InternshipDetails");
    }
}