using Ganaderia.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Ganaderia.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Rancher> Ranchers { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<Herd> Herds { get; set; }
        public DbSet<Farm> Farms { get; set; }
        public DbSet<Specimen> Specimens { get; set; }
        public DbSet<Pathology> Pathology { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog=SysGan_bd");
            }
        }
    }
}
