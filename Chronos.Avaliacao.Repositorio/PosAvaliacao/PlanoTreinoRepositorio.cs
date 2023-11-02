using Chronos.Avaliacao.Conexao;
using Chronos.Avaliacao.Entidade.PosAvaliacao;
using Chronos.Avaliacao.Repositorio.Inteface.PosAvaliacao;

namespace Chronos.Avaliacao.Repositorio.PosAvaliacao
{
    internal class PlanoTreinoRepositorio : IPlanoTreinoRepositorio
    {
        private readonly Contexto _context;
        public PlanoTreinoRepositorio(Contexto context)
        {
            _context = context;
        }
        public IEnumerable<PlanoTreinoEntidade> BuscarPlanoTreinoPorIdCliente(int idCliente)
        {
            return _context.PlanosDeTreino.Where(pl => pl.Id == idCliente).ToList();
        }
    }
}
