using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;
using APIeSistemTreinamento.Repository;

namespace APIeSistemTreinamento.Controllers
{
    [ApiController]
    [Route("api/Empresa")]
    public class EmpresaController : ControllerBase
    {
        private readonly EmpresaRepository _empresaRepository;

        public EmpresaController(EmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Empresa>> BuscarTodos()
        {
            return await _empresaRepository.BuscarTodos();
        }


        [HttpGet("codigo/{id:int}")]
        public async Task<ActionResult<Empresa>> ObterPessoaEmpresa(int id)
        {
            var nomenclaturaEmpresa = await _empresaRepository.ObterPessoaEmpresa(id);
            if (nomenclaturaEmpresa == null)
            {
                return NotFound();
            }
            return nomenclaturaEmpresa;
        }

    }
}
