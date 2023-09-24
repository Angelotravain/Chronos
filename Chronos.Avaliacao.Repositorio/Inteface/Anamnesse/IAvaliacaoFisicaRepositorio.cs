using Chronos.Avaliacao.Entidade.Anamnese;

namespace Chronos.Avaliacao.Repositorio.Inteface.Anamnesse
{
    public interface IAvaliacaoFisicaRepositorio
    {
        IEnumerable<AvaliacaoFisicaEntidade> RetornaTodasAsAvaliacoes();
        AvaliacaoFisicaEntidade RetornaAvaliacaoPorCliente(int IdCliente);
        void CriarAvaliacaoFisica(AvaliacaoFisicaEntidade avaliacao);
    }
}
