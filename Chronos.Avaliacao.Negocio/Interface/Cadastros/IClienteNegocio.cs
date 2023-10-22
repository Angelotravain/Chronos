using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;

namespace Chronos.Avaliacao.Negocio.Interface.Cadastros
{
    public interface IClienteNegocio
    {
        void EditarCliente(ClienteEntidade cliente);
        void SalvarCliente(ClienteEntidade cliente);
        bool ExcluirCliente(int cliente);
        ClienteEntidade RetornarClienteParaAtualizarPorId(int id);
        ClienteEntidade RetornaClientePorIdParaAvaliacao(int idCliente);
        IEnumerable<ClienteEntidade> BuscarTodosOsCLientes();
        ClienteEntidade BuscaClientePorId(int id);
    }
}
