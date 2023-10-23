using AutoMapper;
using Chronos.Avaliacao.DTO.Cadastros;
using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Negocio.Interface.Cadastros;
using Microsoft.AspNetCore.Mvc;

namespace Chronos.Avaliacao.Controller.Controllers.Cadastros
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercicioController : ControllerBase
    {
        private readonly IExercicioNegocio _exercicioNegocio;
        private readonly IMapper _mapper;
        public ExercicioController(IExercicioNegocio exercicioNegocio, IMapper mapper)
        {
            _exercicioNegocio = exercicioNegocio;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BuscarTodosOsExercicios()
        {
            return Ok(_exercicioNegocio.BuscarTodosOsExercicios());
        }

        [HttpGet("{id}")]
        public IActionResult BuscarExercicioPorId(int id)
        {
            var exercicio = _exercicioNegocio.BuscaExercicioPorId(id);
            if (exercicio == null)
                return NotFound();

            return Ok(exercicio);
        }

        [HttpPost]
        public IActionResult CreateExercicio([FromBody] ExercicioDTO novoExercicio)
        {
            if (novoExercicio == null)
                return BadRequest();

            _exercicioNegocio.SalvarExercicio(_mapper.Map<ExercicioDTO, ExercicioEntidade>(novoExercicio));

            return CreatedAtAction(nameof(BuscarExercicioPorId), new { id = novoExercicio.Id }, novoExercicio);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateExercicio(int id, [FromBody] ExercicioDTO exercicioAtualizado)
        {
            if (exercicioAtualizado == null || id != exercicioAtualizado.Id)
                return BadRequest();

            var existente = _exercicioNegocio.BuscaExercicioPorId(id);
            if (existente == null)

                _exercicioNegocio.EditarExercicio(_mapper.Map<ExercicioDTO, ExercicioEntidade>(exercicioAtualizado));

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteExercicio(int id)
        {
            var exercicio = _exercicioNegocio.BuscaExercicioPorId(id);
            if (exercicio == null)
                return NotFound();

            _exercicioNegocio.ExcluirExercicio(exercicio.Id);

            return NoContent();
        }
    }
}
