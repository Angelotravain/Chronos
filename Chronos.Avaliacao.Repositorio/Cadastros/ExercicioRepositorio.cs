using Chronos.Avaliacao.Conexao;
using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;

namespace Chronos.Avaliacao.Repositorio.Cadastros
{
    internal class ExercicioRepositorio : IExercicioRepositorio
    {
        private readonly Contexto _context;
        private readonly IGenerico _generico;

        public ExercicioRepositorio(Contexto context, IGenerico generico)
        {
            _context = context;
            _generico = generico;
        }
        public void SalvarExercicio(ExercicioEntidade exercicio)
        {
            if (exercicio != null)
                _generico.Salvar<ExercicioEntidade>(exercicio);
        }
        public bool ExcluirExercicio(int exercicioId)
        {
            var podeExcluir = false;
            var clienteVinculado = _context.PlanosDeTreino.FirstOrDefault(c => c.ExercicioId == exercicioId);
            if (clienteVinculado == null)
            {
                _generico.Excluir<ExercicioEntidade>(exercicioId);
                podeExcluir = true;
            }
            return podeExcluir;
        }
        public void EditarExercicio(ExercicioEntidade exercicio)
        {
            if (exercicio != null)
                _generico.Editar<ExercicioEntidade>(exercicio, exercicio.Id);
        }
        public IEnumerable<ExercicioEntidade> BuscarTodosOsExercicios()
        {
            return _context.Exercicios.ToList();
        }
        public ExercicioEntidade BuscaExercicioPorId(int id)
        {
            return _context.Exercicios.First(e => e.Id == id);
        }
    }
}
