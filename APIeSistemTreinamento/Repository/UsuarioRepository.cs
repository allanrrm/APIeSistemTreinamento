using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Repository
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public UsuarioRepository(ApiDbContext db) : base(db)
        {

        }

        public async Task<object> ObterUsuarioEmpresa(string login, string senha)
        {


            var usuarioEmpresa = await _dbContext.Usuario.AsNoTracking()
                .Include(c => c.Empresas)     
                .ThenInclude(c => c.Pessoa)
                .Where(c => c.Login == login && c.Senha == senha)
                .Select ( x => new
                {
                    NomeUsuario = x.Pessoa.NomeRazaoSocial,
                    NomesEmpresas = x.Empresas.Select(e => e.Pessoa.NomeRazaoSocial).ToList()
                })
                .FirstOrDefaultAsync();



            return usuarioEmpresa;
        }
    }
}
