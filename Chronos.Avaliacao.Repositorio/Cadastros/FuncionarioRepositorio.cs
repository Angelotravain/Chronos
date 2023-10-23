using Chronos.Avaliacao.Conexao;
using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;

namespace Chronos.Avaliacao.Repositorio.Cadastros
{
    internal class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly Contexto _context;
        public FuncionarioRepositorio(Contexto context)
        {
            _context = context;
        }
        public IEnumerable<FuncionarioEntidade> BuscarTodosOsFuncionarios()
        {
            return _context.Funcionarios.ToList();
        }
        public IEnumerable<FuncionarioEntidade> BuscarFuncionarioPeloNome(string nome)
        {
            return _context.Funcionarios.Where(f => f.Nome.Contains(nome)).ToList();
        }
        public FuncionarioEntidade BuscarFuncionarioPorId(int id)
        {
            return _context.Funcionarios.FirstOrDefault(f => f.Id == id);
        }
    }
}
