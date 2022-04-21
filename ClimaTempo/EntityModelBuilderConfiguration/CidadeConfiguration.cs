using ClimaTempo.Models;
using System.Data.Entity.ModelConfiguration;

namespace ClimaTempo.EntityModelBuilderConfiguration
{
    public class CidadeConfiguration : EntityTypeConfiguration<Cidade>
    {
        public CidadeConfiguration()
        {

            ToTable("Cidade");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(200).IsRequired();
            
            HasRequired(x => x.Estado)
                .WithMany(g => g.Cidades)
                .HasForeignKey(s => s.EstadoId)
                .WillCascadeOnDelete(false);

        }
    }
}