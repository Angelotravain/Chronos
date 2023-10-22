using AutoMapper;
using Chronos.Avaliacao.DTO.Anamnese;
using Chronos.Avaliacao.Negocio.Interface.Anamnese;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Avaliacao.Anamnese
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnotacaoController : ControllerBase
    {
        private readonly IAnotacaoNegocio _anotacaoNegocio;
        private readonly IMapper _mapper;

        public AnotacaoController(IAnotacaoNegocio anotacaoNegocio, IMapper mapper)
        {
            _anotacaoNegocio = anotacaoNegocio;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult BuscarAnotacaoPorId(int id)
        {
            var anotacao = _anotacaoNegocio.GetRepositorio().BuscarAnotacaoPorAvaliacao(id);
            if (anotacao == null)
            {
                return NotFound();
            }
            return Ok(anotacao);
        }

        [HttpPost]
        public IActionResult CriarAnotacao([FromBody] AnotacaoDTO novaAnotacao)
        {
            if (novaAnotacao == null)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(BuscarAnotacaoPorId), new { id = novaAnotacao.Id }, novaAnotacao);
        }

        [HttpDelete("{idAvaliacao}")]
        public IActionResult DeletarAnotacao(int idAvaliacao)
        {
            var anotacao = _anotacaoNegocio.GetRepositorio().BuscarAnotacaoPorAvaliacao(idAvaliacao);
            if (anotacao == null)
            {
                return NotFound();
            }

            _anotacaoNegocio.GetRepositorio().ExcluirAnotacao(anotacao.First().Id);

            return NoContent();
        }
    }
}
