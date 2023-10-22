using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Financeiro
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly List<Pagamento> _pagamentos = new List<Pagamento>();
        private int _nextId = 1;

        [HttpGet]
        public IActionResult GetAllPagamentos()
        {
            return Ok(_pagamentos);
        }

        [HttpGet("{id}")]
        public IActionResult GetPagamentoById(int id)
        {
            var pagamento = _pagamentos.FirstOrDefault(p => p.Id == id);
            if (pagamento == null)
            {
                return NotFound();
            }
            return Ok(pagamento);
        }

        [HttpPost]
        public IActionResult CreatePagamento([FromBody] Pagamento novoPagamento)
        {
            if (novoPagamento == null)
            {
                return BadRequest();
            }

            novoPagamento.Id = _nextId++;
            _pagamentos.Add(novoPagamento);

            return CreatedAtAction(nameof(GetPagamentoById), new { id = novoPagamento.Id }, novoPagamento);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePagamento(int id, [FromBody] Pagamento pagamentoAtualizado)
        {
            if (pagamentoAtualizado == null || id != pagamentoAtualizado.Id)
            {
                return BadRequest();
            }

            var existente = _pagamentos.FirstOrDefault(p => p.Id == id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Valor = pagamentoAtualizado.Valor;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePagamento(int id)
        {
            var pagamento = _pagamentos.FirstOrDefault(p => p.Id == id);
            if (pagamento == null)
            {
                return NotFound();
            }

            _pagamentos.Remove(pagamento);

            return NoContent();
        }
    }

    public class Pagamento
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        // Outros campos do pagamento
    }
}
