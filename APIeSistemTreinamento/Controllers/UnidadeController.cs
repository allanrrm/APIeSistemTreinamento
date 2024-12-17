using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Controllers
{
    [ApiController]
    [Route("api/Unidade")]
    public class UnidadeController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public UnidadeController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Unidade>>> BuscarUnidade()
        {
            return await _context.Unidade.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Unidade>> BuscarUnidade(int id)
        {
            var unidade = await _context.Unidade.FirstOrDefaultAsync(p => p.Id == id);
            if (unidade == null)
            {
                return NotFound();
            }
            return unidade;
        }

        [HttpGet("codigo/{simboloUnidade}")]
        public async Task<ActionResult<Unidade>> BuscarUnidade(string simboloUnidade)
        {
            var unidade = await _context.Unidade.FirstOrDefaultAsync(p => p.Simbolo == simboloUnidade);
            if (unidade == null)
            {
                return NotFound();
            }
            return unidade;
        }

        [HttpPost]
        public async Task<ActionResult<Unidade>> IncluirUnidade(Unidade simboloUnidade)
        {
            if (_context.Unidade == null)
            {
                return Problem("Erro ao criar uma unidade, contate o suporte");
            }

            if (!ModelState.IsValid)
            {
                return ValidationProblem(new ValidationProblemDetails(ModelState)
                {
                    Title = "Um ou mais erros de ,validação ocorreram"
                });
            }

            _context.Unidade.Add(simboloUnidade);
            await _context.SaveChangesAsync();

            return Created();
        }

        [HttpPut]
        public async Task<ActionResult<Unidade>> AtualizarUnidade(int id, Unidade simboloUnidade)
        {
            if (id != simboloUnidade.Id)
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

            _context.Entry(simboloUnidade).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> DeletarUnidade(int id)
        {
            if (_context.Unidade == null)
            {
                NotFound();
            }
            var simboloUnidade = await _context.Unidade.FindAsync(id);

            if (simboloUnidade == null)
            {
                return NotFound();
            }
            _context.Unidade.Remove(simboloUnidade);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
