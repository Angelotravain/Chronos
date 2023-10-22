using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Negocio.Interface.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;

namespace Chronos.Avaliacao.Negocio.Cadastros
{
    internal class ClienteNegocio : IClienteNegocio
    {
        private readonly IClienteRepositorio _repositorio;
        public ClienteNegocio(IClienteRepositorio clienterepositorio)
        {
            _repositorio = clienterepositorio;
        }

        public void EditarCliente(ClienteEntidade cliente)
        {
            _repositorio.EditarCliente(cliente);
        }
        public void SalvarCliente(ClienteEntidade cliente)
        {
            _repositorio.SalvarCliente(cliente);
        }
        public bool ExcluirCliente(int cliente)
        {
            return _repositorio.ExcluirCliente(cliente);
        }
        public ClienteEntidade BuscaClientePorId(int id)
        {
            return _repositorio.BuscaClientePorId(id);
        }
        public ClienteEntidade RetornarClienteParaAtualizarPorId(int id)
        {
            return _repositorio.RetornarClienteParaAtualizarPorId(id);
        }
        public ClienteEntidade RetornaClientePorIdParaAvaliacao(int idCliente)
        {
            return _repositorio.RetornaClientePorIdParaAvaliacao(idCliente);
        }
        public IEnumerable<ClienteEntidade> BuscarTodosOsCLientes()
        {
            return _repositorio.BuscarTodosOsCLientes();
        }
    }
}
