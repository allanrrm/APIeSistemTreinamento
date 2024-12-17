using APIeSistemTreinamento.Data.Mapping;
using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cfop> Cfop { get; set; }
        public DbSet<Unidade> Unidade { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<UF> UF { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Empresa> Empresa { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new PessoaMapping());

            //modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApiDbContext).Assembly);
        }


    }
}
