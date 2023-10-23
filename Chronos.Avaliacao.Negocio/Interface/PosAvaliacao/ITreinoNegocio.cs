using Chronos.Avaliacao.Entidade.PosAvaliacao;

namespace Chronos.Avaliacao.Negocio.Interface.PosAvaliacao
{
    public interface ITreinoNegocio
    {
        void SalvarTreino(TreinoEntidade treino);
        void EditarTreino(TreinoEntidade treino);
        IEnumerable<TreinoEntidade> BuscarTreinosPorId(int id);
        IEnumerable<TreinoEntidade> BuscarTreinoPorIdCliente(int idCliente);
    }
}
