using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.EntityConfigurations;

public class InternshipDelayRequestConfiguration : IEntityTypeConfiguration<InternshipDelayRequest>
{
    public void Configure(EntityTypeBuilder<InternshipDelayRequest> builder)
    {
        builder.HasKey(entity => entity.Id);
    }
}