using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Repository
{
    public class CidadeRepository : Repository<Cidade>
    {
        public CidadeRepository(ApiDbContext db) : base(db)
        {
            
        }
        public async Task<Cidade> BuscarPorNome(string nomeCidade)
        {
            return await _dbSet.FirstOrDefaultAsync(p => p.Nome == nomeCidade.ToUpper());

        }

    }
}
