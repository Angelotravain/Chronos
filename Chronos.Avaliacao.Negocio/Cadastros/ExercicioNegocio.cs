using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Negocio.Interface.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;

namespace Chronos.Avaliacao.Negocio.Cadastros
{
    internal class ExercicioNegocio : IExercicioNegocio
    {
        private readonly IExercicioRepositorio _exercicioRepositorio;
        public ExercicioNegocio(IExercicioRepositorio exercicio)
        {
            _exercicioRepositorio = exercicio;
        }

        public void SalvarExercicio(ExercicioEntidade exercicio)
        {
            _exercicioRepositorio.SalvarExercicio(exercicio);
        }
        public bool ExcluirExercicio(int exercicioId)
        {
            return _exercicioRepositorio.ExcluirExercicio(exercicioId);
        }
        public void EditarExercicio(ExercicioEntidade exercicio)
        {
            _exercicioRepositorio.EditarExercicio(exercicio);
        }
        public IEnumerable<ExercicioEntidade> BuscarTodosOsExercicios()
        {
            return _exercicioRepositorio.BuscarTodosOsExercicios();
        }
        public ExercicioEntidade BuscaExercicioPorId(int id)
        {
            return _exercicioRepositorio.BuscaExercicioPorId(id);
        }
    }
}
