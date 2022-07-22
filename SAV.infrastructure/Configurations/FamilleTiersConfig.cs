using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAV.core.Entities;


namespace SAV.infrastructure.Configurations
{
    public class FamilleTiersConfig : IEntityTypeConfiguration<FamilleTiers>
    {
        public void Configure(EntityTypeBuilder<FamilleTiers> builder)
        {
            builder.HasKey(t => t.Id);
        }
    }
}
