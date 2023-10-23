using Chronos.Avaliacao.Entidade.Financeiro;

namespace Chronos.Avaliacao.Repositorio.Inteface.Financeiro
{
    public interface IPagamentoRepositorio
    {
        public IEnumerable<PagamentoEntidade> BuscarTodosOsPagamentos();
        public IEnumerable<PagamentoEntidade> BuscarPagamentoPorIdCliente(int idCliente);
        PagamentoEntidade BuscarPagamentoPorId(int id);
    }
}
