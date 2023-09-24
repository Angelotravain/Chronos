using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Anamnese
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnotacaoController : ControllerBase
    {
        private readonly List<Anotacao> _anotacoes = new List<Anotacao>();
        private int _nextId = 1;

        [HttpGet]
        public IActionResult GetAllAnotacoes()
        {
            return Ok(_anotacoes);
        }

        [HttpGet("{id}")]
        public IActionResult GetAnotacaoById(int id)
        {
            var anotacao = _anotacoes.FirstOrDefault(a => a.Id == id);
            if (anotacao == null)
            {
                return NotFound();
            }
            return Ok(anotacao);
        }

        [HttpPost]
        public IActionResult CreateAnotacao([FromBody] Anotacao novaAnotacao)
        {
            if (novaAnotacao == null)
            {
                return BadRequest();
            }

            novaAnotacao.Id = _nextId++;
            _anotacoes.Add(novaAnotacao);

            return CreatedAtAction(nameof(GetAnotacaoById), new { id = novaAnotacao.Id }, novaAnotacao);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAnotacao(int id, [FromBody] Anotacao anotacaoAtualizada)
        {
            if (anotacaoAtualizada == null || id != anotacaoAtualizada.Id)
            {
                return BadRequest();
            }

            var existente = _anotacoes.FirstOrDefault(a => a.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Texto = anotacaoAtualizada.Texto;

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PartialUpdateAnotacao(int id, [FromBody] Dictionary<string, object> campos)
        {
            if (campos == null)
            {
                return BadRequest();
            }

            var existente = _anotacoes.FirstOrDefault(a => a.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            foreach (var campo in campos)
            {
                if (campo.Key.Equals("Texto", StringComparison.OrdinalIgnoreCase))
                {
                    existente.Texto = campo.Value.ToString();
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAnotacao(int id)
        {
            var anotacao = _anotacoes.FirstOrDefault(a => a.Id == id);
            if (anotacao == null)
            {
                return NotFound();
            }

            _anotacoes.Remove(anotacao);

            return NoContent();
        }
    }

    public class Anotacao
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        // Outros campos da anotação
    }
}
