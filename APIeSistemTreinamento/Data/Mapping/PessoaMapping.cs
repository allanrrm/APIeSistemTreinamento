using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIeSistemTreinamento.Data.Mapping
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("pessoa");
            builder.HasKey(pes => pes.Id);
            builder.Property(pes => pes.Id).HasColumnName("id").ValueGeneratedOnAdd().IsRequired();           
            builder.Property(p => p.Conjuge).HasColumnName("conjuge").HasDefaultValue(null);
            builder.Property(p => p.Mae).HasColumnName("mae").HasColumnType("VARCHAR(100)").HasDefaultValue();
            builder.Property(p => p.Pai).HasColumnName("pai").HasDefaultValue("3");
            builder.Property(p => p.NomeRazaoSocial).HasColumnName("nome_razao_social").HasColumnType("VARCHAR(150)").IsRequired();
            builder.Property(p => p.ApelidoNomeFantasia).HasColumnName("apelido_nome_fantasia").HasColumnType("VARCHAR(150)");
            builder.Property(p => p.TipoPessoa).HasColumnName("tipo").HasConversion<int>().IsRequired();
            builder.Property(p => p.CpfCnpj).HasColumnName("cpf_cnpj").HasColumnType("VARCHAR(14)").HasDefaultValue("");
            builder.Property(p => p.Identidade).HasColumnName("identidade").HasColumnType("VARCHAR(20)").HasDefaultValue("");
            builder.Property(p => p.EmissorIdentidade).HasColumnName("emissor_identidade").HasColumnType("VARCHAR(20)").HasDefaultValue("");
            builder.Property(p => p.InscricaoProdutorRural).HasColumnName("inscricao_produtor_rural").HasColumnType("VARCHAR(20)").HasDefaultValue("");
            builder.Property(p => p.InscricaoEstadual).HasColumnName("inscricao_estadual").HasColumnType("VARCHAR(20)").HasDefaultValue("");
            builder.Property(p => p.InscricaoMunicipal).HasColumnName("inscricao_municipal").HasColumnType("VARCHAR(20)").HasDefaultValue("");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("BOOLEAN").IsRequired();



        }
    }
}
