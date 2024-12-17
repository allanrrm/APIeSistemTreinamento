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

        public async Task<Usuario> ObterUsuarioEmpresa(int id)
        {
            var usuarioEmpresa = await _dbContext.Usuario.AsNoTracking()
                .Include(c => c.Empresas)     
                .ThenInclude(c => c.Pessoa)
                .FirstOrDefaultAsync(c => c.Id == id);
            return usuarioEmpresa;
        }
    }
}
