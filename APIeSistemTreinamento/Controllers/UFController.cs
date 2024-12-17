using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Controllers
{
    [ApiController]
    [Route("api/UF")]
    public class UFController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public UFController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UF>>> GetUF()
        {
            return await _context.UF.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<UF>> GetUF(int id)
        {
            var estado = await _context.UF.FirstOrDefaultAsync(p => p.Id == id);
            if (estado == null)
            {
                return NotFound();
            }
            return estado;
        }

        [HttpGet("{siglaUf}")]
        public async Task<ActionResult<UF>> GetUF(string siglaUf)
        {
            var estado = await _context.UF.FirstOrDefaultAsync(p => p.SiglaUF == siglaUf);
            if (estado == null)
            {
                return NotFound();
            }
            return estado;
        }


    }
}
