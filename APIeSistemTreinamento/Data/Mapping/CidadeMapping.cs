using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIeSistemTreinamento.Data.Mapping
{
    public class CidadeMapping : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("cidade");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int").IsRequired();
            builder.Property(x => x.IdEstado).HasColumnName("id_estado").HasColumnType("int").IsRequired();
            builder.Property(x => x.Nome).HasColumnName("nome").HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(x => x.CodigoIBGE).HasColumnName("codigo_ibge").HasColumnType("int");
            builder.Property(x => x.Ativo).HasColumnName("ativo").HasColumnType("bool").IsRequired();

            //id integer NOT NULL DEFAULT nextval('cidade_id_seq'::regclass),
            //id_estado integer NOT NULL DEFAULT 0,
            //nome character varying(100) NOT NULL DEFAULT ''::character varying,
            //codigo_ibge integer NOT NULL DEFAULT 0,
            //ativo boolean NOT NULL DEFAULT false,
        }
    }
}
