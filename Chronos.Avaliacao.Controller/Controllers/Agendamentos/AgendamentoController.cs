using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Agendamentos
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private readonly List<Agendamento> _agendamentos = new List<Agendamento>();
        private int _nextId = 1;

        [HttpGet]
        public IActionResult GetAllAgendamentos()
        {
            return Ok(_agendamentos);
        }

        [HttpGet("{id}")]
        public IActionResult GetAgendamentoById(int id)
        {
            var agendamento = _agendamentos.FirstOrDefault(a => a.Id == id);
            if (agendamento == null)
            {
                return NotFound();
            }
            return Ok(agendamento);
        }

        [HttpPost]
        public IActionResult CreateAgendamento([FromBody] Agendamento novoAgendamento)
        {
            if (novoAgendamento == null)
            {
                return BadRequest();
            }

            novoAgendamento.Id = _nextId++;
            _agendamentos.Add(novoAgendamento);

            return CreatedAtAction(nameof(GetAgendamentoById), new { id = novoAgendamento.Id }, novoAgendamento);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAgendamento(int id, [FromBody] Agendamento agendamentoAtualizado)
        {
            if (agendamentoAtualizado == null || id != agendamentoAtualizado.Id)
            {
                return BadRequest();
            }

            var existente = _agendamentos.FirstOrDefault(a => a.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Nome = agendamentoAtualizado.Nome;

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PartialUpdateAgendamento(int id, [FromBody] Dictionary<string, object> campos)
        {
            if (campos == null)
            {
                return BadRequest();
            }

            var existente = _agendamentos.FirstOrDefault(a => a.Id == id);
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
        public IActionResult DeleteAgendamento(int id)
        {
            var agendamento = _agendamentos.FirstOrDefault(a => a.Id == id);
            if (agendamento == null)
            {
                return NotFound();
            }

            _agendamentos.Remove(agendamento);

            return NoContent();
        }
    }

    public class Agendamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        // Outros campos do agendamento
    }
}
