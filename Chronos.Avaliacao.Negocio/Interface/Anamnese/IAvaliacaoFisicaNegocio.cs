using Chronos.Avaliacao.Entidade.Anamnese;
using Chronos.Avaliacao.Repositorio.Inteface.Anamnesse;

namespace Chronos.Avaliacao.Negocio.Interface.Anamnese
{
    public interface IAvaliacaoFisicaNegocio
    {
        void CriarAvaliacaoFisica(AvaliacaoFisicaEntidade avaliacao);
        IAvaliacaoFisicaRepositorio GetRepositorio();
    }
}
