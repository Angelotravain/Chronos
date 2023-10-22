using AutoMapper;
using Chronos.Avaliacao.DTO.Cadastros;
using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Negocio.Interface.Cadastros;
using Microsoft.AspNetCore.Mvc;

namespace Chronos.Avaliacao.Controller.Controllers.Cadastros
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteNegocio _clienteNegocio;
        private readonly IMapper _mapper;
        public ClienteController(IClienteNegocio clienteNegocio, IMapper mapper)
        {
            _clienteNegocio = clienteNegocio;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BuscarTodosOsClientes()
        {
            return Ok(_clienteNegocio.BuscarTodosOsCLientes());
        }

        [HttpGet("{id}")]
        public IActionResult BuscarClientePorId(int id)
        {
            var cliente = _clienteNegocio.BuscaClientePorId(id);
            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult CreateCliente([FromBody] ClienteDTO novoCliente)
        {
            if (novoCliente == null)
                return BadRequest();

            _clienteNegocio.SalvarCliente(_mapper.Map<ClienteDTO, ClienteEntidade>(novoCliente));

            return CreatedAtAction(nameof(BuscarClientePorId), new { id = novoCliente.Id }, novoCliente);
        }

        [HttpPut("{id}")]
        public IActionResult EditarCliente(int id, [FromBody] ClienteDTO clienteAtualizado)
        {
            if (clienteAtualizado == null || id != clienteAtualizado.Id)
                return BadRequest();

            var existente = _clienteNegocio.BuscaClientePorId(id);
            if (existente == null)
                return NotFound();

            _clienteNegocio.EditarCliente(_mapper.Map<ClienteDTO, ClienteEntidade>(clienteAtualizado));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirCliente(int id)
        {
            var cliente = _clienteNegocio.BuscaClientePorId(id);
            if (cliente == null)
                return NotFound();

            _clienteNegocio.ExcluirCliente(cliente.Id);

            return NoContent();
        }
    }
}
