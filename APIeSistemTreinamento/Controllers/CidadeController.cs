using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using APIeSistemTreinamento.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Controllers
{
    [ApiController]
    [Route("api/Cidade")]
    public class CidadeController : ControllerBase
    {
        private readonly CidadeRepository _cidadeRepository;

        [HttpGet]
        public async Task<IEnumerable<Cidade>> BuscarTodos()
        {
            return await _cidadeRepository.BuscarTodos();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Cidade>> BuscarPorId(int id)
        {
            var cidade = await _cidadeRepository.BuscarPorId(id);
            if (cidade == null)
            {
                return NotFound();
            }
            return cidade;
        }

        [HttpGet("{nomeCidade}")]
        public async Task<ActionResult<Cidade>> BuscarPorNome(string nomeCidade)
        {
            var cidade = await _cidadeRepository.BuscarPorNome(nomeCidade);
            if (cidade == null)
            {
                return NotFound();
            }
            return cidade;
        }



    }
}
