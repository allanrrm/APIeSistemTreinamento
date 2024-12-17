using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIeSistemTreinamento.Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id_pessoa");
            builder.Property(p => p.Login).HasColumnName("login").IsRequired();
            builder.Property(p => p.Senha).HasColumnName("senha").IsRequired();
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("BOOLEAN").IsRequired();
            builder.Property(p => p.Administrador).HasColumnName("administrador").HasColumnType("BOOLEAN").IsRequired();

            builder.HasOne(p => p.Pessoa)
                   .WithOne()
                   .HasForeignKey<Pessoa>(p => p.Id);

            builder.HasMany(e => e.Empresas)
                   .WithMany()
                   .UsingEntity<UsuarioEmpresa>();
        }
    }
}
