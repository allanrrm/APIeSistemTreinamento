using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIeSistemTreinamento.Data.Mapping
{
    public class UnidadeMapping : IEntityTypeConfiguration<Unidade>
    {
        public void Configure(EntityTypeBuilder<Unidade> builder)
        {
            builder.ToTable("unidade");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int").IsRequired();
            builder.Property(x => x.Simbolo).HasColumnName("simbolo").HasColumnType("VARCHAR(10)").IsRequired();
            builder.Property(x => x.Nome).HasColumnName("nome").HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").HasColumnType("bool").IsRequired();


            //      id integer NOT NULL DEFAULT nextval('unidade_id_seq'::regclass),
            //simbolo character varying(10) NOT NULL,
            //nome character varying(50) NOT NULL DEFAULT ''::character varying,
            //ativo boolean NOT NULL DEFAULT false,
            //CONSTRAINT "PK_public.unidade" PRIMARY KEY(id)
        }
    }
}
