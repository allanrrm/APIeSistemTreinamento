using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using APIeSistemTreinamento.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Controllers
{
    [ApiController]
    [Route("api/Cfop")]
    public class CfopController : ControllerBase
    {
        //private readonly CfopRepository _cfopRepos

        private readonly CfopRepository _cfopRepository;

        public CfopController(CfopRepository cfopRepository)
        {
            _cfopRepository = cfopRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Cfop>> BuscarTodos()
        {
            var buscarTodos = await _cfopRepository.BuscarTodos();

            return buscarTodos;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Cfop>> BuscarPorId(int id)
        {
            var idCfop = await _cfopRepository.BuscarPorId(id);
            if (idCfop == null)
            {
                return NotFound();
            }

            return idCfop;

        }

        [HttpGet("Codigo/{codigo}")]
        public async Task<ActionResult<Cfop>> ObterPorCodigo(string codigo)
        {
            return await _cfopRepository.BuscarPorCodigo(codigo);
        }

        [HttpPost]
        public async Task<ActionResult<Cfop>> Adicionar(Cfop cfop)
        {
            await _cfopRepository.Adicionar(cfop);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult<Cfop>> Atualizar(Cfop cfop)
        {
            await _cfopRepository.Atualizar(cfop);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult<Cfop>> Deletar(int id)
        {
            await _cfopRepository.Remover(id);
            return NoContent();
        }









        //private readonly ApiDbContext _context;

        //public CFOPController(ApiDbContext context)
        //{
        //    _context = context;
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<CFOP>>> GetCFOP()
        //{
        //    return await _context.CFOP.ToListAsync();
        //}

        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<CFOP>> GetCFOP(int id)
        //{
        //    var cfop = await _context.CFOP.FirstOrDefaultAsync(p => p.Id == id);
        //    if (cfop == null)
        //    {
        //        return NotFound();
        //    }
        //    return cfop;
        //}

        //[HttpGet("codigo/{codigoCfop}")]
        //public async Task<ActionResult<CFOP>> GetCFOP(string codigoCfop)
        //{
        //    var cfop = await _context.CFOP.FirstOrDefaultAsync(p => p.CodigoCFOP == codigoCfop);
        //    if (cfop == null)
        //    {
        //        return NotFound();
        //    }
        //    return cfop;
        //}

        //[HttpPost]
        //public async Task<ActionResult<CFOP>> IncluirCFOP(CFOP cfop)
        //{
        //    if (_context.CFOP == null)
        //    {
        //        return Problem("Erro ao criar um CFOP, contate o suporte");
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return ValidationProblem(new ValidationProblemDetails(ModelState)
        //        {
        //            Title = "Um ou mais erros de ,validação ocorreram"
        //        });
        //    }

        //    _context.CFOP.Add(cfop);
        //    await _context.SaveChangesAsync();

        //    return Created();
        //}

        //[HttpPut]
        //public async Task<ActionResult<CFOP>> AtualizarCFOP(int id, CFOP cfop)
        //{
        //    if (id != cfop.Id)
        //    {
        //        return BadRequest();
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return ValidationProblem(new ValidationProblemDetails(ModelState)
        //        {
        //            Title = "Um ou mais erros de validação ocorreram"
        //        });
        //    }

        //    _context.Entry(cfop).State = EntityState.Modified;

        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //[HttpDelete]
        //public async Task<ActionResult> DeletarCFOP(int id)
        //{
        //    if (_context.CFOP == null)
        //    {
        //        NotFound();
        //    }
        //    var cfop = await _context.CFOP.FindAsync(id);

        //    if (cfop == null)
        //    {
        //        return NotFound();
        //    }
        //    _context.CFOP.Remove(cfop);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}
    }
}
