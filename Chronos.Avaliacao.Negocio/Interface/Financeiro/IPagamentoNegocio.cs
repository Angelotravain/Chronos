using Chronos.Avaliacao.Entidade.Financeiro;

namespace Chronos.Avaliacao.Negocio.Interface.Financeiro
{
    public interface IPagamentoNegocio
    {
        void SalvarPagamento(PagamentoEntidade usuario);
        void EditarPagamento(PagamentoEntidade usuario);
        void EstornarPagamento(PagamentoEntidade usuario);
        IEnumerable<PagamentoEntidade> BuscarTodosOsPagamentos();
        IEnumerable<PagamentoEntidade> BuscarPagamentoPorIdCliente(int idCliente);
        PagamentoEntidade BuscarPagamentoPorId(int id);
    }
}
