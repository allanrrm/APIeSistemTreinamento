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
    }
}
