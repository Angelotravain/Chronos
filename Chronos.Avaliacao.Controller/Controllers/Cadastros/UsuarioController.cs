using AutoMapper;
using Chronos.Avaliacao.DTO.Cadastros;
using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Negocio.Interface.Cadastros;
using Microsoft.AspNetCore.Mvc;

namespace Chronos.Avaliacao.Controller.Controllers.Cadastros
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioNegocio _usuarioNegocio;
        private readonly IMapper _mapper;
        public UsuarioController(IUsuarioNegocio ususarioNegocio, IMapper mapper)
        {
            _usuarioNegocio = ususarioNegocio;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BuscarTodosUsuarios()
        {
            return Ok(_usuarioNegocio.BuscarTodosOsUsuarios());
        }

        [HttpGet("{id}")]
        public IActionResult BuscarUsuarioPorId(int id)
        {
            var usuario = _usuarioNegocio.BuscarUsuarioPorId(id);
            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }
        [HttpGet("{nome}")]
        public IActionResult BuscarUsuarioPorNome(string nome)
        {
            var usuario = _usuarioNegocio.BuscarUsuarioPorNome(nome);
            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult SalvarUsuario([FromBody] UsuarioDTO novoUsuario)
        {
            if (novoUsuario == null)
                return BadRequest();

            _usuarioNegocio.SalvarUsuario(_mapper.Map<UsuarioDTO, UsuarioEntidade>(novoUsuario));

            return CreatedAtAction(nameof(BuscarUsuarioPorId), new { id = novoUsuario.Id }, novoUsuario);
        }

        [HttpPut("{id}")]
        public IActionResult EditarUsuario(int id, [FromBody] UsuarioDTO usuarioAtualizado)
        {
            if (usuarioAtualizado == null || id != usuarioAtualizado.Id)
                return BadRequest();

            var existente = _usuarioNegocio.BuscarUsuarioPorId(id);
            if (existente == null)
                return NotFound();

            _usuarioNegocio.EditarUsuario(_mapper.Map<UsuarioDTO, UsuarioEntidade>(usuarioAtualizado));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirUsuario(int id)
        {
            var usuario = _usuarioNegocio.BuscarUsuarioPorId(id);
            if (usuario == null)
                return NotFound();

            _usuarioNegocio.ExcluirUsuario(id);

            return NoContent();
        }
    }
}
