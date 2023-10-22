using Chronos.Avaliacao.Entidade.PosAvaliacao;

namespace Chronos.Avaliacao.Negocio.Interface.PosAvaliacao
{
    public interface IPlanoTreinoNegocio
    {
        IEnumerable<PlanoTreinoEntidade> BuscarTodosPlanosDeTreinoPorAluno(int idCliente);
        bool SalvarPlanoTreino(PlanoTreinoEntidade planoTreino);
        bool EditarPlanoTreino(PlanoTreinoEntidade planoTreino);
    }
}
