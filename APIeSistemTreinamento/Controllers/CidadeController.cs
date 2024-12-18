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
        [HttpPost]
        public async Task<ActionResult<Cidade>> Adicionar(Cidade cidade)
        {
            await _cidadeRepository.Adicionar(cidade);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult<Cidade>> Atualizar(Cidade cidade)
        {
            await _cidadeRepository.Atualizar(cidade);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult<Cidade>> Deletar(int id)
        {
            await _cidadeRepository.Remover(id);
            return NoContent();
        }


    }
}
