using AutoMapper;
using Chronos.Avaliacao.DTO.Financeiro;
using Chronos.Avaliacao.Entidade.Financeiro;
using Chronos.Avaliacao.Negocio.Interface.Financeiro;
using Microsoft.AspNetCore.Mvc;

namespace Chronos.Avaliacao.Controller.Controllers.Financeiro
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly IPagamentoNegocio _pagamentoNegocio;
        private readonly IMapper _mapper;
        public PagamentoController(IPagamentoNegocio pagamentoNegocio, IMapper mapper)
        {
            _pagamentoNegocio = pagamentoNegocio;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult BuscarTodosPagamentos()
        {
            return Ok(_pagamentoNegocio.BuscarTodosOsPagamentos());
        }

        [HttpGet("{idCliente}")]
        public IActionResult BuscarPagamentosPorIdCliente(int idCliente)
        {
            var pagamento = _pagamentoNegocio.BuscarPagamentoPorIdCliente(idCliente);
            if (pagamento == null)
                return NotFound();

            return Ok(pagamento);
        }

        [HttpPost]
        public IActionResult SalvarPagamento([FromBody] PagamentoDTO novoPagamento)
        {
            if (novoPagamento == null)
                return BadRequest();

            _pagamentoNegocio.SalvarPagamento(_mapper.Map<PagamentoDTO, PagamentoEntidade>(novoPagamento));

            return CreatedAtAction(nameof(BuscarPagamentosPorIdCliente), new { id = novoPagamento.IdCliente }, novoPagamento);
        }

        [HttpPut("{id}")]
        public IActionResult EstornarPagamento(int id, [FromBody] PagamentoDTO pagamentoAtualizado)
        {
            if (pagamentoAtualizado == null || id != pagamentoAtualizado.Id)
                return BadRequest();

            _pagamentoNegocio.EstornarPagamento(_mapper.Map<PagamentoDTO, PagamentoEntidade>(pagamentoAtualizado));

            return NoContent();
        }
    }
}
