using ClimaTempo.Models;
using System.Data.Entity.ModelConfiguration;

namespace ClimaTempo.EntityModelBuilderConfiguration
{
    public class PrevisaoClimaConfiguration : EntityTypeConfiguration<PrevisaoClima>
    {
        public PrevisaoClimaConfiguration()
        {

            ToTable("PrevisaoClima");
            HasKey(x => x.Id);
            Property(x => x.Clima.Nome).HasColumnName("Clima").HasMaxLength(15).IsRequired();
            Property(x => x.TemperaturaMinima).HasColumnType("decimal").IsRequired();
            Property(x => x.TemperaturaMaxima).HasColumnType("decimal").IsRequired();
            Property(x => x.DataPrevisao).HasColumnType("datetime").IsRequired();

            HasRequired(x => x.Cidade)
             .WithMany(g => g.PrevisoesClima)
             .HasForeignKey(s => s.CidadeId)
             .WillCascadeOnDelete(false);


        }

    }
}