using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Repository
{
    public class PessoaRepository : Repository<Pessoa>
    {
        public PessoaRepository(ApiDbContext db) : base(db)
        {

        }

        public async Task<Pessoa> BuscarPorNome(string cpfCnpj)
        {
            return await _dbSet.FirstOrDefaultAsync(p => p.CpfCnpj == cpfCnpj.ToUpper());

        }

    }
}
