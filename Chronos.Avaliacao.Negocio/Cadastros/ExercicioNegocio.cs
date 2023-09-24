using Chronos.Avaliacao.Negocio.Interface.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;

namespace Chronos.Avaliacao.Negocio.Cadastros
{
    internal class ExercicioNegocio : IExercicioNegocio
    {
        private readonly IExercicioRepositorio _exercicio;
        public ExercicioNegocio(IExercicioRepositorio exercicio)
        {
            _exercicio = exercicio;
        }
        public IExercicioRepositorio GetRepositorio() { return _exercicio; }
    }
}
