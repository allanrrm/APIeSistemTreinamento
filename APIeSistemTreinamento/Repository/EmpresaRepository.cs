using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using Microsoft.EntityFrameworkCore;


namespace APIeSistemTreinamento.Repository
{
    public class EmpresaRepository : Repository<Empresa>
    {

        public EmpresaRepository(ApiDbContext context) : base(context)
        {


        }

        public async Task<Empresa> ObterPessoaEmpresa(int id)
        {
            return await _dbContext.Empresa.AsNoTracking()
                .Include(c => c.Pessoa)
                .FirstOrDefaultAsync(c => c.Id == id);
        }



    }
}
