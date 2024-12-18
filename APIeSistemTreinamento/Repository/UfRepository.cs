using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Repository
{
    public class UfRepository : Repository<Uf>
    {
        public UfRepository(ApiDbContext db) : base(db)
        {
            
        }
        public async Task<Uf> BuscarPorNome(string nomeEstado)
        {
            return await _dbSet.FirstOrDefaultAsync(p => p.SiglaUF == nomeEstado.ToUpper() || p.Nome == nomeEstado);

        }

    }
}
