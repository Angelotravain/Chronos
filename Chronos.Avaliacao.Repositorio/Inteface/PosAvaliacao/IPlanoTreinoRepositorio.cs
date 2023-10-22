using Chronos.Avaliacao.Entidade.PosAvaliacao;

namespace Chronos.Avaliacao.Repositorio.Inteface.PosAvaliacao
{
    public interface IPlanoTreinoRepositorio
    {
        IEnumerable<PlanoTreinoEntidade> BuscarPlanoTreinoPorIdCliente(int idCliente);
    }
}
