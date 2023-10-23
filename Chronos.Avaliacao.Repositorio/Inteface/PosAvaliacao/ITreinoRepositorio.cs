using Chronos.Avaliacao.Entidade.PosAvaliacao;

namespace Chronos.Avaliacao.Repositorio.Inteface.PosAvaliacao
{
    public interface ITreinoRepositorio
    {
        IEnumerable<TreinoEntidade> BuscarTreinoPorId(int id);
        IEnumerable<TreinoEntidade> BuscarTreinoPorIdCliente(int idCliente);
    }
}
