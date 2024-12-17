using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIeSistemTreinamento.Data.Mapping
{
    public class EmpresaMapping : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {

                builder.ToTable("empresa");

                builder.HasKey(e => e.Id);

                builder.Property(e => e.Id).HasColumnName("id_pessoa").IsRequired().HasDefaultValue(0);

                builder.Property(e => e.IdContador).HasColumnName("id_contador");

                builder.Property(e => e.Codigo).HasColumnName("codigo").HasMaxLength(2);

                builder.Property(e => e.Nomenclatura).HasColumnName("nomenclatura").HasMaxLength(10);

                builder.Property(e => e.RazaoSocialSintegra).HasColumnName("razao_social_sintegra").HasMaxLength(35);

                builder.Property(e => e.CapitalSocial).HasColumnName("capital_social").IsRequired().HasPrecision(15, 4).HasDefaultValue(0);

                builder.Property(e => e.EmitenteNfe).HasColumnName("emitente_nfe").IsRequired().HasDefaultValue(false);

                builder.Property(e => e.Ativo).HasColumnName("ativo").IsRequired().HasDefaultValue(false);

                builder.Property(e => e.CodigoContabil).HasColumnName("codigo_contabil").HasMaxLength(20);

                builder.Property(e => e.CodigoAlternativo).HasColumnName("codigo_alternativo").HasMaxLength(50);

                builder.Property(e => e.IdGrupoEmpresa).HasColumnName("id_grupo_empresa");

                builder.Property(e => e.AliqCredSimplesNacional).HasColumnName("aliq_cred_simples_nacional").IsRequired().HasPrecision(15, 4).HasDefaultValue(0);

                builder.Property(e => e.EmailPortalContador).HasColumnName("email_portal_contador").HasMaxLength(100);

                builder.Property(e => e.SenhaPortalContador).HasColumnName("senha_portal_contador").HasMaxLength(255);

                builder
                .HasOne(e => e.Pessoa)
                .WithOne()
                .HasForeignKey<Pessoa>(f => f.Id)
                .OnDelete(DeleteBehavior.Cascade);

            //Blog => Pessoa
            //BlogHeader => Empresa
        }
    }

}
