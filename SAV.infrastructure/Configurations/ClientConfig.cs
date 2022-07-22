using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAV.core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.infrastructure.Configurations
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(t => t.Id);
    }
}
}
