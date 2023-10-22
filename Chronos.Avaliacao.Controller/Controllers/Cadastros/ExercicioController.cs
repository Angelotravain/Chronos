using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Cadastros
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercicioController : ControllerBase
    {
        private readonly List<Exercicio> _exercicios = new List<Exercicio>();
        private int _nextId = 1;

        [HttpGet]
        public IActionResult GetAllExercicios()
        {
            return Ok(_exercicios);
        }

        [HttpGet("{id}")]
        public IActionResult GetExercicioById(int id)
        {
            var exercicio = _exercicios.FirstOrDefault(e => e.Id == id);
            if (exercicio == null)
            {
                return NotFound();
            }
            return Ok(exercicio);
        }

        [HttpPost]
        public IActionResult CreateExercicio([FromBody] Exercicio novoExercicio)
        {
            if (novoExercicio == null)
            {
                return BadRequest();
            }

            novoExercicio.Id = _nextId++;
            _exercicios.Add(novoExercicio);

            return CreatedAtAction(nameof(GetExercicioById), new { id = novoExercicio.Id }, novoExercicio);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateExercicio(int id, [FromBody] Exercicio exercicioAtualizado)
        {
            if (exercicioAtualizado == null || id != exercicioAtualizado.Id)
            {
                return BadRequest();
            }

            var existente = _exercicios.FirstOrDefault(e => e.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Nome = exercicioAtualizado.Nome;

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteExercicio(int id)
        {
            var exercicio = _exercicios.FirstOrDefault(e => e.Id == id);
            if (exercicio == null)
            {
                return NotFound();
            }

            _exercicios.Remove(exercicio);

            return NoContent();
        }
    }

    public class Exercicio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        // Outros campos do exercício
    }
}
