using ClimaTempo.EntityModelBuilderConfiguration;
using ClimaTempo.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ClimaTempo.Database
{
    public class AppDbContext : DbContext
    {

        public AppDbContext():base("AppDbContext")
        {

        }

        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Estado> Estados { get; set; }

        public DbSet<PrevisaoClima> PrevisaoClimas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new CidadeConfiguration());
            modelBuilder.Configurations.Add(new EstadoConfiguration());
            modelBuilder.Configurations.Add(new PrevisaoClimaConfiguration());

        }



    }
}