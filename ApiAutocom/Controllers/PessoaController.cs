using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Controllers
{
    [ApiController]
    [Route("api/Pessoa")]
    public class PessoaController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public PessoaController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetPessoa()
        {
            return await _context.Pessoa.ToListAsync();
        }

        [HttpGet("{CpfCnpj}")]
        public async Task<ActionResult<Pessoa>> GetPessoa(string cpfCnpj)
        {
            var pessoa = await _context.Pessoa.FirstOrDefaultAsync(p => p.CpfCnpj == cpfCnpj);
            if (pessoa == null)
            {
                return NotFound();
            }
            return pessoa;
        }
    }
}
