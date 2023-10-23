using AutoMapper;
using Chronos.Avaliacao.DTO.Anamnese;
using Chronos.Avaliacao.Entidade.Anamnese;
using Chronos.Avaliacao.Negocio.Interface.Anamnese;
using Microsoft.AspNetCore.Mvc;

namespace Chronos.Avaliacao.Controller.Controllers.Avaliacao.Anamnese
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoFisicaController : ControllerBase
    {
        private readonly IAvaliacaoFisicaNegocio _avaliacaoFisicaNegocio;
        private readonly IMapper _mapper;
        public AvaliacaoFisicaController(IAvaliacaoFisicaNegocio avaliacaoFisicaNegocio, IMapper mapper)
        {
            _avaliacaoFisicaNegocio = avaliacaoFisicaNegocio;
            _mapper = mapper;
        }

        [HttpGet("{idCliente}")]
        public AvaliacaoFisicaDTO BuscarAvaliacaoPorIdCliente(int idCliente)
        {
            return _mapper.Map<AvaliacaoFisicaDTO>(_avaliacaoFisicaNegocio.GetRepositorio().RetornaAvaliacaoPorCliente(idCliente));
        }

        [HttpPost]
        public IActionResult CreateAvaliacao([FromBody] AvaliacaoFisicaDTO novaAvaliacao)
        {
            if (novaAvaliacao == null)
                return BadRequest();

            _avaliacaoFisicaNegocio.CriarAvaliacaoFisica(_mapper.Map<AvaliacaoFisicaEntidade>(novaAvaliacao));

            return Ok();
        }
    }
}
