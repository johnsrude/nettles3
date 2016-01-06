using Microsoft.Data.Entity.Metadata.Builders;

namespace NettlesApi.Models
{
    public class CallerConfiguration
    {
        public CallerConfiguration(EntityTypeBuilder<Caller> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.FullName).IsRequired();
        }
    }
}
