using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Agendamentos
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensagemController : ControllerBase
    {
        private readonly List<Mensagem> _mensagens = new List<Mensagem>();
        private int _nextId = 1;

        [HttpGet]
        public IActionResult GetAllMensagens()
        {
            return Ok(_mensagens);
        }

        [HttpGet("{id}")]
        public IActionResult GetMensagemById(int id)
        {
            var mensagem = _mensagens.FirstOrDefault(m => m.Id == id);
            if (mensagem == null)
            {
                return NotFound();
            }
            return Ok(mensagem);
        }

        [HttpPost]
        public IActionResult CreateMensagem([FromBody] Mensagem novaMensagem)
        {
            if (novaMensagem == null)
            {
                return BadRequest();
            }

            novaMensagem.Id = _nextId++;
            _mensagens.Add(novaMensagem);

            return CreatedAtAction(nameof(GetMensagemById), new { id = novaMensagem.Id }, novaMensagem);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMensagem(int id, [FromBody] Mensagem mensagemAtualizada)
        {
            if (mensagemAtualizada == null || id != mensagemAtualizada.Id)
            {
                return BadRequest();
            }

            var existente = _mensagens.FirstOrDefault(m => m.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Texto = mensagemAtualizada.Texto;

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PartialUpdateMensagem(int id, [FromBody] Dictionary<string, object> campos)
        {
            if (campos == null)
            {
                return BadRequest();
            }

            var existente = _mensagens.FirstOrDefault(m => m.Id == id);
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
        public IActionResult DeleteMensagem(int id)
        {
            var mensagem = _mensagens.FirstOrDefault(m => m.Id == id);
            if (mensagem == null)
            {
                return NotFound();
            }

            _mensagens.Remove(mensagem);

            return NoContent();
        }
    }

    public class Mensagem
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        // Outros campos da mensagem
    }
}
