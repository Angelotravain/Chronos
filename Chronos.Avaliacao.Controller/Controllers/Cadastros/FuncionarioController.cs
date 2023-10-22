using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Cadastros
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly List<Funcionario> _funcionarios = new List<Funcionario>();
        private int _nextId = 1;

        [HttpGet]
        public IActionResult GetAllFuncionarios()
        {
            return Ok(_funcionarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetFuncionarioById(int id)
        {
            var funcionario = _funcionarios.FirstOrDefault(f => f.Id == id);
            if (funcionario == null)
            {
                return NotFound();
            }
            return Ok(funcionario);
        }

        [HttpPost]
        public IActionResult CreateFuncionario([FromBody] Funcionario novoFuncionario)
        {
            if (novoFuncionario == null)
            {
                return BadRequest();
            }

            novoFuncionario.Id = _nextId++;
            _funcionarios.Add(novoFuncionario);

            return CreatedAtAction(nameof(GetFuncionarioById), new { id = novoFuncionario.Id }, novoFuncionario);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFuncionario(int id, [FromBody] Funcionario funcionarioAtualizado)
        {
            if (funcionarioAtualizado == null || id != funcionarioAtualizado.Id)
            {
                return BadRequest();
            }

            var existente = _funcionarios.FirstOrDefault(f => f.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Nome = funcionarioAtualizado.Nome;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFuncionario(int id)
        {
            var funcionario = _funcionarios.FirstOrDefault(f => f.Id == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            _funcionarios.Remove(funcionario);

            return NoContent();
        }
    }

    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        // Outros campos do funcionário
    }
}
