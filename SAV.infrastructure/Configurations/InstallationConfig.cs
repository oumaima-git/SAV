using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAV.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.infrastructure.Configurations
{
    public class InstallationConfig : IEntityTypeConfiguration<Installation>
    {
        public void Configure(EntityTypeBuilder<Installation> builder)
        {
            builder.HasKey(t => t.Id);
        }
    }
}
