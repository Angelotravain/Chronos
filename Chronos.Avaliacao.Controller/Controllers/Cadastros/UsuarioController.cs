using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Cadastros
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly List<Usuario> _usuarios = new List<Usuario>();
        private int _nextId = 1;

        [HttpGet]
        public IActionResult GetAllUsuarios()
        {
            return Ok(_usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            var usuario = _usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult CreateUsuario([FromBody] Usuario novoUsuario)
        {
            if (novoUsuario == null)
            {
                return BadRequest();
            }

            novoUsuario.Id = _nextId++;
            _usuarios.Add(novoUsuario);

            return CreatedAtAction(nameof(GetUsuarioById), new { id = novoUsuario.Id }, novoUsuario);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUsuario(int id, [FromBody] Usuario usuarioAtualizado)
        {
            if (usuarioAtualizado == null || id != usuarioAtualizado.Id)
            {
                return BadRequest();
            }

            var existente = _usuarios.FirstOrDefault(u => u.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Nome = usuarioAtualizado.Nome;

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PartialUpdateUsuario(int id, [FromBody] Dictionary<string, object> campos)
        {
            if (campos == null)
            {
                return BadRequest();
            }

            var existente = _usuarios.FirstOrDefault(u => u.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            foreach (var campo in campos)
            {
                if (campo.Key.Equals("Nome", StringComparison.OrdinalIgnoreCase))
                {
                    existente.Nome = campo.Value.ToString();
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            var usuario = _usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            _usuarios.Remove(usuario);

            return NoContent();
        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        // Outros campos do usuário
    }
}
