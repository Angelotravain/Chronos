using Chronos.Avaliacao.Entidade.Cadastros;

namespace Chronos.Avaliacao.Negocio.Interface.Cadastros
{
    public interface IFuncionarioNegocio
    {
        void SalvarFuncionario(FuncionarioEntidade funcionario);
        void EditarFuncionario(FuncionarioEntidade funcionario);
        void ExcluirFuncionario(int idFuncionario);
        IEnumerable<FuncionarioEntidade> BuscarTodosOsFuncionarios();
        IEnumerable<FuncionarioEntidade> BuscarFuncionarioPeloNome(string nome);
        FuncionarioEntidade BuscarFuncionarioPorId(int id);
    }
}
