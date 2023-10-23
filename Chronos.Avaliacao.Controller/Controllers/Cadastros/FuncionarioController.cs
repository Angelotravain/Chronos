using AutoMapper;
using Chronos.Avaliacao.DTO.Cadastros;
using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Negocio.Interface.Cadastros;
using Microsoft.AspNetCore.Mvc;

namespace Chronos.Avaliacao.Controller.Controllers.Cadastros
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioNegocio _funcionarioNegocio;
        private readonly IMapper _mapper;
        public FuncionarioController(IFuncionarioNegocio funcionarioNegocio, IMapper mapper)
        {
            _funcionarioNegocio = funcionarioNegocio;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult BuscarTodosFuncionarios()
        {
            return Ok(_funcionarioNegocio.BuscarTodosOsFuncionarios());
        }

        [HttpGet("{id}")]
        public IActionResult BuscarFuncionarioPorId(int id)
        {
            var funcionario = _funcionarioNegocio.BuscarFuncionarioPorId(id);
            if (funcionario == null)
                return NotFound();

            return Ok(funcionario);
        }
        [HttpGet("{nome}")]
        public IActionResult BuscarFuncionarioPorNome(string nome)
        {
            var funcionario = _funcionarioNegocio.BuscarFuncionarioPeloNome(nome);
            if (funcionario == null)
                return NotFound();

            return Ok(funcionario);
        }

        [HttpPost]
        public IActionResult SalvarFuncionario([FromBody] FuncionarioDTO novoFuncionario)
        {
            if (novoFuncionario == null)
                return BadRequest();

            _funcionarioNegocio.SalvarFuncionario(_mapper.Map<FuncionarioDTO, FuncionarioEntidade>(novoFuncionario));

            return CreatedAtAction(nameof(BuscarFuncionarioPorId), new { id = novoFuncionario.Id }, novoFuncionario);
        }

        [HttpPut("{id}")]
        public IActionResult EditarFuncionario(int id, [FromBody] FuncionarioDTO funcionarioAtualizado)
        {
            if (funcionarioAtualizado == null || id != funcionarioAtualizado.Id)
                return BadRequest();

            var existente = _funcionarioNegocio.BuscarFuncionarioPorId(id);
            if (existente == null)
                return NotFound();

            _funcionarioNegocio.EditarFuncionario(_mapper.Map<FuncionarioDTO, FuncionarioEntidade>(funcionarioAtualizado));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirFuncionario(int id)
        {
            var funcionario = _funcionarioNegocio.BuscarFuncionarioPorId(id);
            if (funcionario == null)
                return NotFound();

            _funcionarioNegocio.ExcluirFuncionario(id);

            return NoContent();
        }
    }
}
