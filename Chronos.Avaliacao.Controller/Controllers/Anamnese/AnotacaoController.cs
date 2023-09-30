using AutoMapper;
using Chronos.Avaliacao.DTO.Anamnese;
using Chronos.Avaliacao.Entidade.Anamnese;
using Chronos.Avaliacao.Negocio.Interface.Anamnese;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chronos.Avaliacao.Controller.Controllers.Anamnese
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
        public IActionResult GetAnotacaoById(int id)
        {
            var anotacao = _anotacaoNegocio.GetRepositorio().BuscarAnotacaoPorAvaliacao(id);
            if (anotacao == null)
            {
                return NotFound();
            }
            return Ok(anotacao);
        }

        //[HttpPost]
        //public IActionResult CreateAnotacao([FromBody] Anotacao novaAnotacao)
        //{
        //    if (novaAnotacao == null)
        //    {
        //        return BadRequest();
        //    }

        //    novaAnotacao.Id = _nextId++;
        //    _anotacoes.Add(novaAnotacao);

        //    return CreatedAtAction(nameof(GetAnotacaoById), new { id = novaAnotacao.Id }, novaAnotacao);
        //}

        //[HttpPut("{id}")]
        //public IActionResult UpdateAnotacao(int id, [FromBody] Anotacao anotacaoAtualizada)
        //{
        //    if (anotacaoAtualizada == null || id != anotacaoAtualizada.Id)
        //    {
        //        return BadRequest();
        //    }

        //    var existente = _anotacoes.FirstOrDefault(a => a.Id == id);
        //    if (existente == null)
        //    {
        //        return NotFound();
        //    }

        //    existente.Texto = anotacaoAtualizada.Texto;

        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteAnotacao(int id)
        //{
        //    var anotacao = _anotacoes.FirstOrDefault(a => a.Id == id);
        //    if (anotacao == null)
        //    {
        //        return NotFound();
        //    }

        //    _anotacoes.Remove(anotacao);

        //    return NoContent();
        //}
    }
}
