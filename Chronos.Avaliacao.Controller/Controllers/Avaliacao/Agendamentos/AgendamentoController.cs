using AutoMapper;
using Chronos.Avaliacao.DTO.Agendamentos;
using Chronos.Avaliacao.Entidade.Agendamentos;
using Chronos.Avaliacao.Negocio.Interface.Agendamentos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Chronos.Avaliacao.Controller.Controllers.Avaliacao.Agendamentos
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
        public IEnumerable<AgendamentoDTO> BuscarTodosAgendamentos()
        {
            return _mapper.Map<IEnumerable<AgendamentoDTO>>(_negocio.ListarTodosOsAgendamentos());
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
            return Ok(_negocio.SalvarAgendamento(_mapper.Map<AgendamentoEntidade>(novoAgendamento)));
        }

        [HttpPut("{id}")]
        public IActionResult EditarAgendamento(int id, [FromBody] AgendamentoDTO agendamentoAtualizado)
        {
            if (agendamentoAtualizado == null)
            {
                return BadRequest();
            }
            agendamentoAtualizado.Id = id;
            var existente = _negocio.EditarAgendamento(_mapper.Map<AgendamentoEntidade>(agendamentoAtualizado));
            if (existente == null)
            {
                return NotFound();
            }

            return Ok(existente);
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirAgendamento(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            return Ok(_negocio.ExcluirAgendamento((int)id));
        }
    }
}
