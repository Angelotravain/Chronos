using Chronos.Avaliacao.Conexao;
using Chronos.Avaliacao.Entidade.PosAvaliacao;
using Chronos.Avaliacao.Repositorio.Inteface.PosAvaliacao;

namespace Chronos.Avaliacao.Repositorio.PosAvaliacao
{
    internal class TreinoRepositorio : ITreinoRepositorio
    {
        private readonly Contexto _context;
        public TreinoRepositorio(Contexto context)
        {
            _context = context;
        }
        public IEnumerable<TreinoEntidade> BuscarTreinoPorId(int id)
        {
            return _context.Treinos.Where(t => t.Id == id).ToList();
        }
        public IEnumerable<TreinoEntidade> BuscarTreinoPorIdCliente(int idCliente)
        {
            return _context.Treinos.Where(t => t.IdCliente == idCliente).ToList();
        }
    }
}
