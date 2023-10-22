using Chronos.Avaliacao.Conexao;
using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;

namespace Chronos.Avaliacao.Repositorio.Cadastros
{
    internal class ClienteRepositorio : IClienteRepositorio
    {
        private readonly Contexto _context;
        private readonly IGenerico _generico;

        public ClienteRepositorio(Contexto context, IGenerico generico)
        {
            _context = context;
            _generico = generico;
        }
        public void SalvarCliente(ClienteEntidade cliente)
        {
            if (cliente != null)
                _generico.Salvar<ClienteEntidade>(cliente);
        }
        public bool ExcluirCliente(int cliente)
        {
            var podeExcluir = false;
            var clienteVinculado = _context.AvaliacoesFisicas.FirstOrDefault(c => c.IdCliente == cliente);
            if (clienteVinculado == null)
            {
                _generico.Excluir<ClienteEntidade>(cliente);
                podeExcluir = true;
            }
            return podeExcluir;
        }
        public void EditarCliente(ClienteEntidade cliente)
        {
            if (cliente != null)
                _generico.Editar<ClienteEntidade>(cliente, cliente.Id);
        }
        public IEnumerable<ClienteEntidade> BuscarTodosOsClientes()
        {
            return _context.Clientes.ToList();
        }
        public ClienteEntidade BuscaClientePorId(int id)
        {
            ClienteEntidade clienteSaida = null;
            var avaliacaoFisica = _context.AvaliacoesFisicas.FirstOrDefault(a => a.IdCliente == id);
            if (avaliacaoFisica == null)
            {
                clienteSaida = _context.Clientes.First(c => c.Id == id);

            }
            return clienteSaida;
        }
        public ClienteEntidade RetornarClienteParaAtualizarPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(c => c.Id == id);
        }
        public ClienteEntidade RetornaClientePorIdParaAvaliacao(int idCliente)
        {
            return _context.Clientes.First(c => c.Id == idCliente);
        }
        public IEnumerable<ClienteEntidade> BuscarTodosOsCLientes()
        {
            return _context.Clientes.ToList();
        }
    }
}
