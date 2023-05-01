using Data.Data.Identity;
using Data.Data.InformationData;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Data Source=DESKTOP-DN31MTS;Initial Catalog=ConstructorDB;Trusted_Connection=True;TrustServerCertificate=true;TrustServerCertificate=true;";

                optionsBuilder.UseSqlServer(connectionString);

                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
       
        }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<TestOnServer> TestOnServers { get; set; }
        public DbSet<AsignTestUser> AsignTestUsers { get; set; }
    }

}

