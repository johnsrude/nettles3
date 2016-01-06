using Microsoft.Data.Entity.Metadata.Builders;

namespace NettlesApi.Models
{
    public class VenueConfiguration
    {
        public VenueConfiguration(EntityTypeBuilder<Venue> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.City).IsRequired();
            builder.Property(p => p.State).IsRequired();
        }
    }
}
