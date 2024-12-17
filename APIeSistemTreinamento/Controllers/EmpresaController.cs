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
        private readonly EmpresaRepository _fornecedorRepository;

        public EmpresaController(EmpresaRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Empresa>> BuscarTodos()
        {
            return await _fornecedorRepository.BuscarTodos();
        }


        [HttpGet("codigo/{id:int}")]
        public async Task<ActionResult<Empresa>> ObterPessoaEmpresa(int id)
        {
            var nomenclaturaEmpresa = await _fornecedorRepository.ObterPessoaEmpresa(id);
            if (nomenclaturaEmpresa == null)
            {
                return NotFound();
            }
            return nomenclaturaEmpresa;
        }

        //[HttpGet("{nomeEmpresa}")]
        //public async Task<ActionResult<Empresa>> GetUF(string nomeEmpresa)
        //{
        //    var nomenclaturaEmpresa = await _context.Empresa.FirstOrDefaultAsync(p => p.Nomenclatura == nomeEmpresa);
        //    if (nomenclaturaEmpresa == null)
        //    {
        //        return NotFound();
        //    }
        //    return nomenclaturaEmpresa;
        //}


    }
}
