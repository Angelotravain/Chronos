using AutoMapper;
using Chronos.Avaliacao.DTO.Agendamentos;
using Chronos.Avaliacao.Entidade.Agendamentos;
using Chronos.Avaliacao.Negocio.Interface.Agendamentos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Chronos.Avaliacao.Controller.Controllers.Agendamentos
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private readonly IAgendamentoNegocio _negocio;
        private readonly IMapper _mapper;
        public AgendamentoController(IAgendamentoNegocio negocio, IMapper mapper)
        {
            _negocio = negocio;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult BuscarTodosAgendamentos()
        {
            return Ok(_negocio.ListarTodosOsAgendamentos());
        }

        [HttpGet("{idCliente}")]
        public IActionResult BuscarAgendamentoPorId(int idCliente)
        {
            var agendamento = _negocio.ListarHistoricoAgendamentoCliente(idCliente);
            if (agendamento == null)
            {
                return NotFound();
            }
            return Ok(agendamento);
        }

        [HttpPost]
        public IActionResult CriarAgendamento([FromBody] AgendamentoDTO novoAgendamento)
        {
            if (novoAgendamento == null)
            {
                return BadRequest();
            }
            _negocio.SalvarAgendamento(_mapper.Map<AgendamentoEntidade>(novoAgendamento));

            return CreatedAtAction(nameof(BuscarAgendamentoPorId), new { id = novoAgendamento.Id }, novoAgendamento);
        }

        [HttpPut("{id}")]
        public IActionResult EditarAgendamento(int id, [FromBody] AgendamentoDTO agendamentoAtualizado)
        {
            if (agendamentoAtualizado == null || id != agendamentoAtualizado.Id)
            {
                return BadRequest();
            }

            var existente = _negocio.EditarAgendamento(_mapper.Map<AgendamentoEntidade>(agendamentoAtualizado));
            if (existente == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult EditarParcialAgendamento(int id, [FromBody] Dictionary<string, object> campos)
        {
            if (campos == null)
            {
                return BadRequest();
            }

            var existente = _negocio.EditarAgendamento(_mapper.Map<AgendamentoEntidade>(campos));
            if (existente == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirAgendamento(int id)
        {
            var agendamento = _negocio.BuscarAgendamentoPorId(id);
            if (agendamento == null)
            {
                return NotFound();
            }

            _negocio.ExcluirAgendamento(id);

            return NoContent();
        }
    }
}
