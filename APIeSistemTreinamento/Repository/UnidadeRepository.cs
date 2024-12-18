using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Repository
{
    public class UnidadeRepository : Repository<Unidade>
    {
        public UnidadeRepository(ApiDbContext db) : base(db)
        {

        }

        public async Task<Unidade> BuscarPorNome(string nomeEstado)
        {
            return await _dbSet.FirstOrDefaultAsync(p => p.Nome == nomeEstado.ToUpper());

        }

    }
}
