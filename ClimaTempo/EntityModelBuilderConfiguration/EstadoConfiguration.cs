using ClimaTempo.Models;
using System.Data.Entity.ModelConfiguration;

namespace ClimaTempo.EntityModelBuilderConfiguration
{
    public class EstadoConfiguration : EntityTypeConfiguration<Estado>
    {
        public EstadoConfiguration()
        {
            ToTable("Estado");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(200).IsRequired();
            Property(x => x.Uf).HasColumnType("char").HasMaxLength(2).IsRequired();

        }
    }
}