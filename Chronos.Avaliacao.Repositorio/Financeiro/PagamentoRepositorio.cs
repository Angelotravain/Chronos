using Chronos.Avaliacao.Conexao;
using Chronos.Avaliacao.Entidade.Financeiro;
using Chronos.Avaliacao.Repositorio.Inteface.Financeiro;

namespace Chronos.Avaliacao.Repositorio.Financeiro
{
    internal class PagamentoRepositorio : IPagamentoRepositorio
    {
        private readonly Contexto _context;
        public PagamentoRepositorio(Contexto context)
        {
            _context = context;
        }
        public IEnumerable<PagamentoEntidade> BuscarTodosOsPagamentos()
        {
            return _context.Pagamentos.ToList();
        }
        public IEnumerable<PagamentoEntidade> BuscarPagamentoPorIdCliente(int idCliente)
        {
            return _context.Pagamentos.Where(p => p.IdCliente == idCliente).ToList();
        }
        public PagamentoEntidade BuscarPagamentoPorId(int id)
        {
            return _context.Pagamentos.FirstOrDefault(p => p.Id == id); 
        }
    }
}
