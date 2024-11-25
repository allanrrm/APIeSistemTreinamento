using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIeSistemTreinamento.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(p =>
            {
                p.ToTable("pessoa");
                p.HasKey(p => p.Id);
                p.Property(p => p.Id).HasColumnName("id");
                p.Property(p => p.Conjuge).HasColumnName("conjuge").HasColumnType("VARCHAR(100)");
                p.Property(p => p.Mae).HasColumnName("mae").HasColumnType("VARCHAR(100)");
                p.Property(p => p.Pai).HasColumnName("pai").HasColumnType("VARCHAR(100)");
                p.Property(p => p.NomeRazaoSocial).HasColumnName("nome_razao_social").HasColumnType("VARCHAR(150)").IsRequired().HasDefaultValue("");
                p.Property(p => p.ApelidoNomeFantasia).HasColumnName("apelido_nome_fantasia").HasColumnType("VARCHAR(150)");
                p.Property(p => p.TipoPessoa).HasColumnName("tipo").HasConversion<int>().IsRequired();
                p.Property(p => p.CpfCnpj).HasColumnName("cpf_cnpj").HasColumnType("VARCHAR(14)");
                p.Property(p => p.Identidade).HasColumnName("identidade").HasColumnType("VARCHAR(20)");
                p.Property(p => p.EmissorIdentidade).HasColumnName("emissor_identidade").HasColumnType("VARCHAR(20)");
                p.Property(p => p.InscricaoProdutorRural).HasColumnName("inscricao_produtor_rural").HasColumnType("VARCHAR(20)");
                p.Property(p => p.InscricaoEstadual).HasColumnName("inscricao_estadual").HasColumnType("VARCHAR(20)");
                p.Property(p => p.InscricaoMunicipal).HasColumnName("inscricao_municipal").HasColumnType("VARCHAR(20)");
                p.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("BOOELAN").IsRequired();
            }

            );
        }
    }
}
