using Microsoft.EntityFrameworkCore;
using SAV.core.Entities;
using SAV.infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.infrastructure
{
    public class RepoContext : DbContext
    {
        public RepoContext(DbContextOptions option) : base(option) { }
        public DbSet<FamilleTiers> FamilleTiers{ get; set; }
       
        public DbSet<Tiers> Tiers { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Ticket> Ticket { get; set; }

  
        public DbSet<Agent> Agent { get; set; }
        public DbSet<Produit> Produit { get; set; }
        public DbSet<Installation> Installation { get; set; }
        public DbSet<Incident> Incident { get; set; }
        public DbSet<Taches> Taches { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Version> Version{ get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseNpgsql("Host=localhost;Database=myDb;Username=postgres;Password=1234");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new FamilleTiersConfig());
            modelBuilder.ApplyConfiguration(new TicketConfig());
            modelBuilder.ApplyConfiguration(new TiersConfig());
            modelBuilder.ApplyConfiguration(new ContactConfig());
            modelBuilder.ApplyConfiguration(new AgentConfig());
            modelBuilder.ApplyConfiguration(new ProduitConfig());
            modelBuilder.ApplyConfiguration(new IncidentConfig());
            modelBuilder.ApplyConfiguration(new InstallationConfig());
            modelBuilder.ApplyConfiguration(new ProduitConfig());
            modelBuilder.ApplyConfiguration(new VersionConfig());
            modelBuilder.ApplyConfiguration(new ClientConfig());




        }
    }
}
