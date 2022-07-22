using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.infrastructure
{
    public class ContextFactory : IDesignTimeDbContextFactory<RepoContext>
    {
            public RepoContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<RepoContext>();
                optionsBuilder.UseNpgsql("Host=localhost;Database=myDb;Username=postgres;Password=1234")
                    .EnableDetailedErrors().EnableSensitiveDataLogging();

                return new RepoContext(optionsBuilder.Options);
            }
        }
    }

