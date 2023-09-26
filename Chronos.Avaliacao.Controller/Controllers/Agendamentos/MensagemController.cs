using AutoMapper;
using Chronos.Avaliacao.DTO.Agendamentos;
using Chronos.Avaliacao.Entidade.Agendamentos;
using Chronos.Avaliacao.Negocio.Interface.Agendamentos;
using Microsoft.AspNetCore.Mvc;

namespace Chronos.Avaliacao.Controller.Controllers.Agendamentos
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensagemController : ControllerBase
    {
        private readonly IMensagemNegocio _negocio;
        private readonly IMapper _mapper;
        public MensagemController(IMensagemNegocio negocio, IMapper mapper)
        {
            _negocio = negocio;
            _mapper = mapper;
        }

        [HttpGet("{idCliente}/{idAgendamento}")]
        public IActionResult BuscarMensagemPorId(int idCliente, int idAgendamento)
        {
            var mensagem = _negocio.GetRepositorio().BuscarMensagemPorAgendamento(idCliente, idAgendamento);
            if (mensagem == null)
            {
                return NotFound();
            }
            return Ok(mensagem);
        }

        [HttpPost]
        public IActionResult CriarMensagem([FromBody] MensagemDTO novaMensagem)
        {
            if (novaMensagem == null)
            {
                return BadRequest();
            }

            _negocio.GetRepositorio().SalvarMensagem(_mapper.Map<MensagemEntidade>(novaMensagem));

            return CreatedAtAction(nameof(BuscarMensagemPorId), new { id = novaMensagem.Id }, novaMensagem);
        }

        [HttpPut("{id}")]
        public IActionResult EditarMensagem(int id, [FromBody] MensagemDTO mensagemAtualizada)
        {
            if (mensagemAtualizada == null || id != mensagemAtualizada.Id)
            {
                return BadRequest();
            }

            _negocio.GetRepositorio().EditarMensagem(_mapper.Map<MensagemEntidade>(mensagemAtualizada));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirMensagem(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            _negocio.GetRepositorio().RemoverMensagem(id);
            return NoContent();
        }
    }
}
