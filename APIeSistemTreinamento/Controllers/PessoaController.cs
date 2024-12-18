using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using APIeSistemTreinamento.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Controllers
{
    [ApiController]
    [Route("api/Pessoa")]
    public class PessoaController : ControllerBase
    {
        private readonly PessoaRepository _pessoaRepository;

        public PessoaController(PessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Pessoa>> BuscarTodos()
        {
            return await _pessoaRepository.BuscarTodos();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Pessoa>> BuscarPorId(int id)
        {
            var Pessoa = await _pessoaRepository.BuscarPorId(id);
            if (Pessoa == null)
            {
                return NotFound();
            }
            return Pessoa;
        }

        [HttpGet("{nomeCidade}")]
        public async Task<ActionResult<Pessoa>> BuscarPorNome(string nomePessoa)
        {
            var Pessoa = await _pessoaRepository.BuscarPorNome(nomePessoa);
            if (Pessoa == null)
            {
                return NotFound();
            }
            return Pessoa;
        }
        [HttpPost]
        public async Task<ActionResult<Pessoa>> Adicionar(Pessoa pessoa)
        {
            await _pessoaRepository.Adicionar(pessoa);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult<Pessoa>> Atualizar(Pessoa pessoa)
        {
            await _pessoaRepository.Atualizar(pessoa);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult<Pessoa>> Deletar(int id)
        {
            await _pessoaRepository.Remover(id);
            return NoContent();
        }
    }
}
