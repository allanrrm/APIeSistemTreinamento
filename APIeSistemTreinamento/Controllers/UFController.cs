using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using APIeSistemTreinamento.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Controllers
{
    [ApiController]
    [Route("api/Uf")]
    public class UfController : ControllerBase
    {
        private readonly UfRepository _ufRepository;

        public UfController(UfRepository ufRepository)
        {
            _ufRepository = ufRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Uf>> BuscarTodos()
        {
            return await _ufRepository.BuscarTodos();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Uf>> BuscarPorId(int id)
        {
            var estado = await _ufRepository.BuscarPorId(id);
            if (estado == null)
            {
                return NotFound();
            }
            return estado;
        }

        [HttpGet("{nomeUf}")]
        public async Task<ActionResult<Uf>> BuscarPorNome(string nomeUf)
        {
            var estado = await _ufRepository.BuscarPorNome(nomeUf);
            if (estado == null)
            {
                return NotFound();
            }
            return estado;
        }
        [HttpPost]
        public async Task<ActionResult<Uf>> Adicionar(Uf uf)
        {
            await _ufRepository.Adicionar(uf);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult<Uf>> Atualizar(Uf uf)
        {
            await _ufRepository.Atualizar(uf);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult<Uf>> Deletar(int id)
        {
            await _ufRepository.Remover(id);
            return NoContent();
        }


    }
}
