using Chronos.Avaliacao.Entidade.Cadastros;

namespace Chronos.Avaliacao.Repositorio.Inteface.Cadastros
{
    public interface IExercicioRepositorio
    {
        void SalvarExercicio(ExercicioEntidade cliente);
        bool ExcluirExercicio(int cliente);
        void EditarExercicio(ExercicioEntidade exercicio);
        IEnumerable<ExercicioEntidade> BuscarTodosOsExercicios();
        ExercicioEntidade BuscaExercicioPorId(int id);
    }
}
