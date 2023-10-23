using Chronos.Avaliacao.Entidade.Cadastros;

namespace Chronos.Avaliacao.Repositorio.Inteface.Cadastros
{
    public interface IFuncionarioRepositorio
    {
        IEnumerable<FuncionarioEntidade> BuscarTodosOsFuncionarios();
        IEnumerable<FuncionarioEntidade> BuscarFuncionarioPeloNome(string nome);
        FuncionarioEntidade BuscarFuncionarioPorId(int id);
    }
}
