using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Models;
using APIeSistemTreinamento.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIeSistemTreinamento.Controllers
{
    
    [ApiController]
    [Route("api/Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioController(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet("{login}")]
        public async Task<ActionResult<object>> ObterUsuarioEmpresa(string login, string senha)
        {
            var nomenclaturaEmpresa = await _usuarioRepository.ObterUsuarioEmpresa(login, senha);

            if (nomenclaturaEmpresa == null)
            {
                return NotFound();
            }
            return nomenclaturaEmpresa;
        }
    
    }
}
