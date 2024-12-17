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

        [HttpGet]
        public async Task<IEnumerable<Usuario>> ObterTodos()
        {
            return await _usuarioRepository.BuscarTodos();
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Usuario>> ObterUsuarioEmpresa(int id)
        {
            var nomenclaturaEmpresa = await _usuarioRepository.ObterUsuarioEmpresa(id);

            if (nomenclaturaEmpresa == null)
            {
                return NotFound();
            }
            return nomenclaturaEmpresa;
        }
        //[HttpDelete]
        //public async Task<ActionResult> DeletarUsuario(int id)
        //{
        //    if (_context.Usuario == null)
        //    {
        //        NotFound();
        //    }
        //    var usuario = await _context.Usuario.FindAsync(id);

        //    if (usuario == null)
        //    {
        //        return NotFound();
        //    }
        //    _context.Usuario.Remove(usuario);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}
    }
}
