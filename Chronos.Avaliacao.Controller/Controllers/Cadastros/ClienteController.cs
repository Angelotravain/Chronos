using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Cadastros
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly List<Cliente> _clientes = new List<Cliente>();
        private int _nextId = 1;

        [HttpGet]
        public IActionResult GetAllClientes()
        {
            return Ok(_clientes);
        }

        [HttpGet("{id}")]
        public IActionResult GetClienteById(int id)
        {
            var cliente = _clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult CreateCliente([FromBody] Cliente novoCliente)
        {
            if (novoCliente == null)
            {
                return BadRequest();
            }

            novoCliente.Id = _nextId++;
            _clientes.Add(novoCliente);

            return CreatedAtAction(nameof(GetClienteById), new { id = novoCliente.Id }, novoCliente);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCliente(int id, [FromBody] Cliente clienteAtualizado)
        {
            if (clienteAtualizado == null || id != clienteAtualizado.Id)
            {
                return BadRequest();
            }

            var existente = _clientes.FirstOrDefault(c => c.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Nome = clienteAtualizado.Nome;

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PartialUpdateCliente(int id, [FromBody] Dictionary<string, object> campos)
        {
            if (campos == null)
            {
                return BadRequest();
            }

            var existente = _clientes.FirstOrDefault(c => c.Id == id);
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
        public IActionResult DeleteCliente(int id)
        {
            var cliente = _clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            _clientes.Remove(cliente);

            return NoContent();
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        // Outros campos do cliente
    }
}
