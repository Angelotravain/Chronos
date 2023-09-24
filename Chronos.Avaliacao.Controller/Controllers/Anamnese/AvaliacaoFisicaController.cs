using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Anamnese
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoFisicaController : ControllerBase
    {
        private readonly List<AvaliacaoFisica> _avaliacoes = new List<AvaliacaoFisica>();
        private int _nextId = 1;

        [HttpGet]
        public IActionResult GetAllAvaliacoes()
        {
            return Ok(_avaliacoes);
        }

        [HttpGet("{id}")]
        public IActionResult GetAvaliacaoById(int id)
        {
            var avaliacao = _avaliacoes.FirstOrDefault(a => a.Id == id);
            if (avaliacao == null)
            {
                return NotFound();
            }
            return Ok(avaliacao);
        }

        [HttpPost]
        public IActionResult CreateAvaliacao([FromBody] AvaliacaoFisica novaAvaliacao)
        {
            if (novaAvaliacao == null)
            {
                return BadRequest();
            }

            novaAvaliacao.Id = _nextId++;
            _avaliacoes.Add(novaAvaliacao);

            return CreatedAtAction(nameof(GetAvaliacaoById), new { id = novaAvaliacao.Id }, novaAvaliacao);
        }
    }

    public class AvaliacaoFisica
    {
        public int Id { get; set; }
        // Outros campos da avaliação física
    }
}
