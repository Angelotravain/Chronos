using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Avaliacao.PosAvaliacao
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreinoController : ControllerBase
    {
        private readonly List<Treino> _treinos = new List<Treino>();
        private int _nextId = 1;

        [HttpGet]
        public IActionResult GetAllTreinos()
        {
            return Ok(_treinos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTreinoById(int id)
        {
            var treino = _treinos.FirstOrDefault(t => t.Id == id);
            if (treino == null)
            {
                return NotFound();
            }
            return Ok(treino);
        }

        [HttpPost]
        public IActionResult CreateTreino([FromBody] Treino novoTreino)
        {
            if (novoTreino == null)
            {
                return BadRequest();
            }

            novoTreino.Id = _nextId++;
            _treinos.Add(novoTreino);

            return CreatedAtAction(nameof(GetTreinoById), new { id = novoTreino.Id }, novoTreino);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTreino(int id, [FromBody] Treino treinoAtualizado)
        {
            if (treinoAtualizado == null || id != treinoAtualizado.Id)
            {
                return BadRequest();
            }

            var existente = _treinos.FirstOrDefault(t => t.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Descricao = treinoAtualizado.Descricao;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTreino(int id)
        {
            var treino = _treinos.FirstOrDefault(t => t.Id == id);
            if (treino == null)
            {
                return NotFound();
            }

            _treinos.Remove(treino);

            return NoContent();
        }
    }

    public class Treino
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        // Outros campos do treino
    }
}
