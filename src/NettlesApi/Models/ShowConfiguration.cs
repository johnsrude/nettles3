using Microsoft.Data.Entity.Metadata.Builders;

namespace NettlesApi.Models
{
    public class ShowConfiguration
    {
        public ShowConfiguration(EntityTypeBuilder<Show> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Time).IsRequired();
            builder.Property(p => p.Title).IsRequired();
        } 
    }
}
