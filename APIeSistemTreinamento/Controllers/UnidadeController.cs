using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using APIeSistemTreinamento.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Controllers
{
    [ApiController]
    [Route("api/Unidade")]
    public class UnidadeController : ControllerBase
    {
        private readonly UnidadeRepository _unidadeRepository;

        public UnidadeController(UnidadeRepository unidadeRepository)
        {
            _unidadeRepository = unidadeRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Unidade>> BuscarTodos()
        {
            return await _unidadeRepository.BuscarTodos();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Unidade>> BuscarPorId(int id)
        {
            var unidade = await _unidadeRepository.BuscarPorId(id);
            if (unidade == null)
            {
                return NotFound();
            }
            return unidade;
        }

        [HttpGet("{unidade}")]
        public async Task<ActionResult<Unidade>> BuscarPorNome(string unidade)
        {
            var unidadePesquisar = await _unidadeRepository.BuscarPorNome(unidade);
            if (unidadePesquisar == null)
            {
                return NotFound();
            }
            return unidadePesquisar;
        }
        [HttpPost]
        public async Task<ActionResult<Unidade>> Adicionar(Unidade unidade)
        {
            await _unidadeRepository.Adicionar(unidade);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult<Unidade>> Atualizar(Unidade unidade)
        {
            await _unidadeRepository.Atualizar(unidade);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult<Unidade>> Deletar(int id)
        {
            await _unidadeRepository.Remover(id);
            return NoContent();
        }

    }
}
