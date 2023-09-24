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
        public void SalvarExercicio(ExercicioEntidade cliente)
        {
            if (cliente != null)
                _generico.Salvar<ExercicioEntidade>(cliente);
        }
        public bool ExcluirExercicio(int cliente)
        {
            var podeExcluir = false;
            var clienteVinculado = _context.AvaliacoesFisicas.FirstOrDefault(c => c.IdCliente == cliente);
            if (clienteVinculado == null)
            {
                _generico.Excluir<ExercicioEntidade>(cliente);
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
            return _context.Exercicios.FirstOrDefault(e => e.Id == id);
        }
    }
}
