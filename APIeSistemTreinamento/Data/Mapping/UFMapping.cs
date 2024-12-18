using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIeSistemTreinamento.Data.Mapping
{
    public class UFMapping : IEntityTypeConfiguration<Uf>
    {
        public void Configure(EntityTypeBuilder<Uf> builder)
        {
            builder.ToTable("estado");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int").IsRequired();
            builder.Property(x => x.IdPais).HasColumnName("id_pais").HasColumnType("int").IsRequired();
            builder.Property(x => x.Nome) .HasColumnName("nome").HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(x => x.SiglaUF).HasColumnName("sigla").HasColumnType("VARCHAR(2)").IsRequired();
            builder.Property(x => x.CodigoIBGE).HasColumnName("codigo_ibge").HasColumnType("integer").IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").HasColumnType("boolean").IsRequired();
            builder.Property(x => x.AliqIcmsInterna).HasColumnName("aliq_icms_interna").HasColumnType("numeric(18,2)").IsRequired();

            //Chave Estrangeira de Cidade N - 1 com Cidade
            builder.HasMany(x => x.Cidades)
                .WithOne(x => x.UF)
                .HasForeignKey(x => x.IdEstado);


            //Chave Estrangeira de Cidade 1 - N com Pais
            builder.HasOne<Pais>(p => p.Pais)
                .WithMany()
                .HasForeignKey(x => x.IdPais);

        }
    }
}
