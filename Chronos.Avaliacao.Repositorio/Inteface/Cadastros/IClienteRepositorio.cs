using Chronos.Avaliacao.Entidade.Cadastros;

namespace Chronos.Avaliacao.Repositorio.Inteface.Cadastros
{
    public interface IClienteRepositorio
    {
        void SalvarCliente(ClienteEntidade cliente);
        bool ExcluirCliente(int cliente);
        void EditarCliente(ClienteEntidade cliente);
        IEnumerable<ClienteEntidade> BuscarTodosOsClientes();
        ClienteEntidade BuscaClientePorId(int id);
        ClienteEntidade RetornarClienteParaAtualizarPorId(int id);
        ClienteEntidade RetornaClientePorIdParaAvaliacao(int idCliente);
        IEnumerable<ClienteEntidade> BuscarTodosOsCLientes();
    }
}
