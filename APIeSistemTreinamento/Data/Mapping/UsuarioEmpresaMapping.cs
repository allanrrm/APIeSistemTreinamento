using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIeSistemTreinamento.Data.Mapping
{
    public class UsuarioEmpresaMapping : IEntityTypeConfiguration<UsuarioEmpresa>
    {
        public void Configure(EntityTypeBuilder<UsuarioEmpresa> builder)
        {
            builder.ToTable("usuario_empresa");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int").IsRequired();
            builder.Property(x => x.IdUsuario).HasColumnName("id_usuario").HasColumnType("int").IsRequired();
            builder.Property(x => x.IdEmpresa).HasColumnName("id_empresa").HasColumnType("int").IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").HasColumnType("bool").IsRequired();
            builder.Property(x => x.Integrar).HasColumnName("integrar").HasColumnType("int").IsRequired();
            builder.Property(x => x.ApenasDav).HasColumnName("apenas_dav").HasColumnType("bool").IsRequired();
            builder.Property(x => x.ApenasNfe).HasColumnName("apenas_nfe").HasColumnType("bool").IsRequired();

            builder.HasOne(e => e.Empresa)
                .WithMany()
                .HasForeignKey(e => e.IdEmpresa);

            builder.HasOne(e => e.Usuario)
                .WithMany()
                .HasForeignKey(e => e.IdUsuario);




            //          id integer NOT NULL DEFAULT nextval('usuario_empresa_id_seq'::regclass),
            //id_usuario integer NOT NULL DEFAULT 0,
            //id_empresa integer NOT NULL DEFAULT 0,
            //ativo boolean NOT NULL DEFAULT false,
            //integrar integer NOT NULL DEFAULT 0,
            //apenas_dav boolean NOT NULL DEFAULT false,
            //apenas_nfe boolean NOT NULL DEFAULT false,
        }
    }
}
