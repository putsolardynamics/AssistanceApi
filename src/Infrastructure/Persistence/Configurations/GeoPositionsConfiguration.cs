using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApiTemplate.Domain.Entities;

namespace RestApiTemplate.Infrastructure.Persistence.Configurations;

public class GeoPositionsConfiguration : IEntityTypeConfiguration<GeoPosition>
{
    public void Configure(EntityTypeBuilder<GeoPosition> builder)
    {
        builder.Property(x => x.Altitude)
            .IsRequired();

        builder.Property(x => x.Latitude)
            .IsRequired();
    }
}