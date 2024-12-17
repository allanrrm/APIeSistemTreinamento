using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIeSistemTreinamento.Data.Mapping
{
    public class CFOPMapping : IEntityTypeConfiguration<Cfop>
    {
        public void Configure(EntityTypeBuilder<Cfop> builder)
        {
        builder.ToTable("cfop");
        builder.HasKey(p => p.Id);
        builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int").IsRequired();
        builder.Property(x => x.CodigoCFOP).HasColumnName("codigo").HasColumnType("VARCHAR(4)").IsRequired();
        builder.Property(x => x.Descricao).HasColumnName("descricao").HasColumnType("VARCHAR(1000)").IsRequired();
        builder.Property(x => x.DescricaoResumida).HasColumnName("descricao_resumida").HasColumnType("VARCHAR(500)").IsRequired(false);
        builder.Property(x => x.CreditaPisCofins).HasColumnName("credita_pis_cofins").HasColumnType("bool").IsRequired();
        builder.Property(x => x.CompoeTotalNota).HasColumnName("compoe_total_nota").HasColumnType("bool").IsRequired();
        builder.Property(x => x.Ativo).HasColumnName("ativo").HasColumnType("bool").IsRequired();
        builder.Property(x => x.TipoCFOP) .HasColumnName("tipo_cfop").HasColumnType("int").IsRequired();
        builder.Property(x => x.GeraMovimentoEstoque).HasColumnName("gera_movimento_estoque") .HasColumnType("bool").IsRequired();
        builder.Property(x => x.TipoBaseCalculoCredito).HasColumnName("tipo_base_calculo_credito").HasColumnType("int").IsRequired();
        }

    //id integer NOT NULL DEFAULT nextval('cfop_id_seq'::regclass),
    //codigo character varying(4) NOT NULL DEFAULT ''::character varying,
    //descricao character varying(1000) NOT NULL DEFAULT ''::character varying,
    //descricao_resumida character varying(500) NOT NULL DEFAULT ''::character varying,
    //credita_pis_cofins boolean NOT NULL DEFAULT false,
    //compoe_total_nota boolean NOT NULL DEFAULT false,
    //ativo boolean NOT NULL DEFAULT false,
    //tipo_cfop integer NOT NULL DEFAULT 0,
    //gera_movimento_estoque boolean NOT NULL DEFAULT false,
    //tipo_base_calculo_credito integer NOT NULL DEFAULT 0,
    //id_plano_conta integer,
    //CONSTRAINT "PK_public.cfop" PRIMARY KEY(id),
    }
}
