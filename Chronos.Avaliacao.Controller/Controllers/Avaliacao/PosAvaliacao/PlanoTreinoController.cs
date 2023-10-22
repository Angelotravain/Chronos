using AutoMapper;
using Chronos.Avaliacao.DTO.PosAvaliacao;
using Chronos.Avaliacao.Entidade.PosAvaliacao;
using Chronos.Avaliacao.Negocio.Interface.PosAvaliacao;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Avaliacao.PosAvaliacao
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanoTreinoController : ControllerBase
    {
        private readonly IPlanoTreinoNegocio _planoTreinoNegocio;
        private readonly IMapper _mapper;
        public PlanoTreinoController(IPlanoTreinoNegocio planoTreinoNegocio, IMapper mapper)
        {
            _planoTreinoNegocio = planoTreinoNegocio;
            _mapper = mapper;
        }

        [HttpGet("{idCliente}")]
        public IActionResult BuscarTodosPlanosTreinoPorCliente(int idCliente)
        {
            var planoTreino = _planoTreinoNegocio.BuscarTodosPlanosDeTreinoPorAluno(idCliente);
            if (planoTreino == null)
            {
                return NotFound();
            }
            return Ok(planoTreino);
        }

        [HttpPost]
        public IActionResult CreatePlanoTreino([FromBody] PlanoTreinoDTO novoPlanoTreino)
        {
            if (novoPlanoTreino == null)
            {
                return BadRequest();
            }

            _planoTreinoNegocio.SalvarPlanoTreino(_mapper.Map<PlanoTreinoDTO, PlanoTreinoEntidade>(novoPlanoTreino));

            return CreatedAtAction(nameof(BuscarTodosPlanosTreinoPorCliente), new { id = novoPlanoTreino.Id }, novoPlanoTreino);
        }

        [HttpPut("{id}")]
        public IActionResult EditarPlanoTreino(int id, [FromBody] PlanoTreinoDTO planoTreinoAtualizado)
        {
            if (planoTreinoAtualizado == null || id != planoTreinoAtualizado.Id)
            {
                return BadRequest();
            }
            planoTreinoAtualizado.Id = id;
            var existente = _planoTreinoNegocio.EditarPlanoTreino(_mapper.Map<PlanoTreinoDTO, PlanoTreinoEntidade>(planoTreinoAtualizado));
            if (existente != true)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
