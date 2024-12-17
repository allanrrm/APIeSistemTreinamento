using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;


namespace APIeSistemTreinamento.Repository
{
    public class CfopRepository : Repository<Cfop>
    {

        public CfopRepository(ApiDbContext context) : base(context)
        {


        }


        public async Task<Cfop> BuscarPorCodigo(string codigo)
        {
            return await _dbSet.FirstOrDefaultAsync(p => p.CodigoCFOP == codigo);
        }



    }
}
