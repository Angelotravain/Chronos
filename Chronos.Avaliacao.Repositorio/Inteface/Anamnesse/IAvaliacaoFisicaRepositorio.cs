using Chronos.Avaliacao.Entidade.Anamnese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Avaliacao.Repositorio.Inteface.Anamnesse
{
    public interface IAvaliacaoFisicaRepositorio
    {
        IEnumerable<AvaliacaoFisicaEntidade> RetornaTodasAsAvaliacoes();
        AvaliacaoFisicaEntidade RetornaAvaliacaoPorCliente(int IdCliente);
        void CriarAvaliacaoFisica(AvaliacaoFisicaEntidade avaliacao);
    }
}
