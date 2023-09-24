using Microsoft.AspNetCore.Http;
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

        // Endpoint para obter todas as mensagens (GET)
        [HttpGet]
        public IActionResult GetAllMensagens()
        {
            return Ok(_mensagens);
        }

        // Endpoint para obter uma mensagem por ID (GET)
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

        // Endpoint para criar uma nova mensagem (POST)
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

        // Endpoint para atualizar uma mensagem (PUT)
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
            // Atualize outros campos conforme necessário

            return NoContent();
        }

        // Endpoint para atualizar parcialmente uma mensagem (PATCH)
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
                // Atualize outros campos conforme necessário
            }

            return NoContent();
        }

        // Endpoint para excluir uma mensagem (DELETE)
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
