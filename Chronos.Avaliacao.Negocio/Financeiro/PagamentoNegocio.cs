using Chronos.Avaliacao.Entidade.Financeiro;
using Chronos.Avaliacao.Negocio.Interface.Financeiro;
using Chronos.Avaliacao.Repositorio.Inteface.Financeiro;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;

namespace Chronos.Avaliacao.Negocio.Financeiro
{
    internal class PagamentoNegocio : IPagamentoNegocio
    {
        private readonly IPagamentoRepositorio _pagamentoRepositorio;
        private readonly IGenerico _classeGenerica;
        private const string PagamentoEstornado = "Pagamento Estornado";
        public PagamentoNegocio(IPagamentoRepositorio pagamentoRepositorio, IGenerico classeGenerica)
        {
            _pagamentoRepositorio = pagamentoRepositorio;
            _classeGenerica = classeGenerica;
        }
        public void SalvarPagamento(PagamentoEntidade usuario)
        {
            _classeGenerica.Salvar<PagamentoEntidade>(usuario);
        }
        public void EditarPagamento(PagamentoEntidade usuario)
        {
            _classeGenerica.Editar<PagamentoEntidade>(usuario, usuario.Id);
        }
        public void EstornarPagamento(PagamentoEntidade usuario)
        {
            usuario.StatusPagamento = PagamentoEstornado;
            _classeGenerica.Editar<PagamentoEntidade>(usuario, usuario.Id);
        }
        public IEnumerable<PagamentoEntidade> BuscarTodosOsPagamentos()
        {
            return _pagamentoRepositorio.BuscarTodosOsPagamentos();
        }
        public IEnumerable<PagamentoEntidade> BuscarPagamentoPorIdCliente(int idCliente)
        {
            return _pagamentoRepositorio.BuscarPagamentoPorIdCliente(idCliente);
        }
        public PagamentoEntidade BuscarPagamentoPorId(int id)
        {
            return _pagamentoRepositorio.BuscarPagamentoPorId(id);
        }
    }
}
