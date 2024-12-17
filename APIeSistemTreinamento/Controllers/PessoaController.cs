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

        [HttpGet("{cpfCnpj}")]
        public async Task<ActionResult<Pessoa>> GetPessoa(string cpfCnpj)
        {
            var pessoa = await _context.Pessoa.FirstOrDefaultAsync(p => p.CpfCnpj == cpfCnpj);
            if (pessoa == null)
            {
                return NotFound();
            }
            return pessoa;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Pessoa>> GetPessoa(int id)
        {
            var pessoa = await _context.Pessoa.FirstOrDefaultAsync(p => p.Id == id);
            if (pessoa == null)
            {
                return NotFound();
            }
            return pessoa;
        }

        [HttpPost]
        public async Task<ActionResult<Pessoa>> IncluirPessoa(Pessoa pessoa)
        {
            if (_context.Pessoa == null)
            {
                return Problem("Erro ao criar uma pessoa, contate o suporte");
            }

            if (!ModelState.IsValid)
            {
                return ValidationProblem(new ValidationProblemDetails(ModelState)
                {
                    Title = "Um ou mais erros de ,validação ocorreram"
                });
            }

            _context.Pessoa.Add(pessoa);
            await _context.SaveChangesAsync();

            return Created();
        }

        [HttpPut]
        public async Task<ActionResult<Pessoa>> AtualizarPessoa(int id, Pessoa pessoa)
        {
            if (id != pessoa.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return ValidationProblem(new ValidationProblemDetails(ModelState)
                {
                    Title = "Um ou mais erros de validação ocorreram"
                });
            }

            _context.Entry(pessoa).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> DeletarPessoa(int id)
        {
            if (_context.Pessoa == null)
            {
                NotFound();
            }
            var pessoa = await _context.Pessoa.FindAsync(id);

            if (pessoa == null)
            {
                return NotFound();
            }
            _context.Pessoa.Remove(pessoa);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
