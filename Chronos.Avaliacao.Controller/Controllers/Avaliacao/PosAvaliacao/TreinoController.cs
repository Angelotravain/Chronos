using AutoMapper;
using Chronos.Avaliacao.DTO.PosAvaliacao;
using Chronos.Avaliacao.Entidade.PosAvaliacao;
using Chronos.Avaliacao.Negocio.Interface.PosAvaliacao;
using Microsoft.AspNetCore.Mvc;

namespace Chronos.Avaliacao.Controller.Controllers.Avaliacao.PosAvaliacao
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreinoController : ControllerBase
    {
        private readonly ITreinoNegocio _treinoNegocio;
        private readonly IMapper _mapper;
        public TreinoController(ITreinoNegocio treinoNegocio, IMapper mapper)
        {
            _treinoNegocio = treinoNegocio;
            _mapper = mapper;
        }

        [HttpGet("{idCliente}")]
        public IActionResult BuscarTrinoPorIdCliente(int idCliente)
        {
            var treino = _treinoNegocio.BuscarTreinoPorIdCliente(idCliente);
            if (treino == null)
            {
                return NotFound();
            }
            return Ok(treino);
        }

        [HttpPost]
        public IActionResult SalvarTreino([FromBody] TreinoDTO novoTreino)
        {
            if (novoTreino == null)
            {
                return BadRequest();
            }

            _treinoNegocio.SalvarTreino(_mapper.Map<TreinoDTO, TreinoEntidade>(novoTreino));

            return CreatedAtAction(nameof(_treinoNegocio.BuscarTreinosPorId), new { id = novoTreino.Id }, novoTreino);
        }

        [HttpPut("{id}")]
        public IActionResult EditarTreino(int id, [FromBody] TreinoDTO treinoAtualizado)
        {
            if (treinoAtualizado == null || id != treinoAtualizado.Id)
            {
                return BadRequest();
            }

            var existente = _treinoNegocio.BuscarTreinosPorId(id);
            if (existente == null)
            {
                return NotFound();
            }

            _treinoNegocio.EditarTreino(_mapper.Map<TreinoDTO, TreinoEntidade>(treinoAtualizado));

            return NoContent();
        }
    }
}
