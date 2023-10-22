using Chronos.Avaliacao.Entidade.Cadastros;

namespace Chronos.Avaliacao.Repositorio.Inteface.Cadastros
{
    public interface IExercicioRepositorio
    {
        void SalvarExercicio(ExercicioEntidade exercicio);
        bool ExcluirExercicio(int exercicioId);
        void EditarExercicio(ExercicioEntidade exercicio);
        IEnumerable<ExercicioEntidade> BuscarTodosOsExercicios();
        ExercicioEntidade BuscaExercicioPorId(int id);
    }
}
