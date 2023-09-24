using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.PosAvaliacao
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanoTreinoController : ControllerBase
    {
        private readonly List<PlanoTreino> _planosTreino = new List<PlanoTreino>();
        private int _nextId = 1;

        [HttpGet]
        public IActionResult GetAllPlanosTreino()
        {
            return Ok(_planosTreino);
        }

        [HttpGet("{id}")]
        public IActionResult GetPlanoTreinoById(int id)
        {
            var planoTreino = _planosTreino.FirstOrDefault(p => p.Id == id);
            if (planoTreino == null)
            {
                return NotFound();
            }
            return Ok(planoTreino);
        }

        [HttpPost]
        public IActionResult CreatePlanoTreino([FromBody] PlanoTreino novoPlanoTreino)
        {
            if (novoPlanoTreino == null)
            {
                return BadRequest();
            }

            novoPlanoTreino.Id = _nextId++;
            _planosTreino.Add(novoPlanoTreino);

            return CreatedAtAction(nameof(GetPlanoTreinoById), new { id = novoPlanoTreino.Id }, novoPlanoTreino);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePlanoTreino(int id, [FromBody] PlanoTreino planoTreinoAtualizado)
        {
            if (planoTreinoAtualizado == null || id != planoTreinoAtualizado.Id)
            {
                return BadRequest();
            }

            var existente = _planosTreino.FirstOrDefault(p => p.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Descricao = planoTreinoAtualizado.Descricao;

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PartialUpdatePlanoTreino(int id, [FromBody] Dictionary<string, object> campos)
        {
            if (campos == null)
            {
                return BadRequest();
            }

            var existente = _planosTreino.FirstOrDefault(p => p.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            foreach (var campo in campos)
            {
                if (campo.Key.Equals("Descricao", StringComparison.OrdinalIgnoreCase))
                {
                    existente.Descricao = campo.Value.ToString();
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePlanoTreino(int id)
        {
            var planoTreino = _planosTreino.FirstOrDefault(p => p.Id == id);
            if (planoTreino == null)
            {
                return NotFound();
            }

            _planosTreino.Remove(planoTreino);

            return NoContent();
        }
    }

    public class PlanoTreino
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        // Outros campos do plano de treino
    }
}
