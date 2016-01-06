using Microsoft.Data.Entity.Metadata.Builders;

namespace NettlesApi.Models
{
    public class ImageConfiguration
    {
        public ImageConfiguration(EntityTypeBuilder<Image> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Picture).IsRequired();
        }
    }
}
