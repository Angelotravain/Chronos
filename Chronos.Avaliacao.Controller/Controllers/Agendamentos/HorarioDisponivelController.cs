using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Agendamentos
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorarioDisponivelController : ControllerBase
    {
        private readonly List<HorarioDisponivel> _horarios = new List<HorarioDisponivel>();
        private int _nextId = 1;

        // Endpoint para obter todos os horários disponíveis (GET)
        [HttpGet]
        public IActionResult GetAllHorarios()
        {
            return Ok(_horarios);
        }

        // Endpoint para obter um horário disponível por ID (GET)
        [HttpGet("{id}")]
        public IActionResult GetHorarioById(int id)
        {
            var horario = _horarios.FirstOrDefault(h => h.Id == id);
            if (horario == null)
            {
                return NotFound();
            }
            return Ok(horario);
        }

        // Endpoint para criar um novo horário disponível (POST)
        [HttpPost]
        public IActionResult CreateHorario([FromBody] HorarioDisponivel novoHorario)
        {
            if (novoHorario == null)
            {
                return BadRequest();
            }

            novoHorario.Id = _nextId++;
            _horarios.Add(novoHorario);

            return CreatedAtAction(nameof(GetHorarioById), new { id = novoHorario.Id }, novoHorario);
        }

        // Endpoint para atualizar um horário disponível (PUT)
        [HttpPut("{id}")]
        public IActionResult UpdateHorario(int id, [FromBody] HorarioDisponivel horarioAtualizado)
        {
            if (horarioAtualizado == null || id != horarioAtualizado.Id)
            {
                return BadRequest();
            }

            var existente = _horarios.FirstOrDefault(h => h.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Hora = horarioAtualizado.Hora;
            // Atualize outros campos conforme necessário

            return NoContent();
        }

        // Endpoint para atualizar parcialmente um horário disponível (PATCH)
        [HttpPatch("{id}")]
        public IActionResult PartialUpdateHorario(int id, [FromBody] Dictionary<string, object> campos)
        {
            if (campos == null)
            {
                return BadRequest();
            }

            var existente = _horarios.FirstOrDefault(h => h.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            foreach (var campo in campos)
            {
                if (campo.Key.Equals("Hora", StringComparison.OrdinalIgnoreCase))
                {
                    existente.Hora = campo.Value.ToString();
                }
                // Atualize outros campos conforme necessário
            }

            return NoContent();
        }

        // Endpoint para excluir um horário disponível (DELETE)
        [HttpDelete("{id}")]
        public IActionResult DeleteHorario(int id)
        {
            var horario = _horarios.FirstOrDefault(h => h.Id == id);
            if (horario == null)
            {
                return NotFound();
            }

            _horarios.Remove(horario);

            return NoContent();
        }
    }

    public class HorarioDisponivel
    {
        public int Id { get; set; }
        public string Hora { get; set; }
        // Outros campos do horário disponível
    }
}
