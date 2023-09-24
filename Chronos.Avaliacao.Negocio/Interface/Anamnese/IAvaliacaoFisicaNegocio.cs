using Chronos.Avaliacao.Entidade.Anamnese;
using Chronos.Avaliacao.Repositorio.Inteface.Anamnesse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Avaliacao.Negocio.Interface.Anamnese
{
    public interface IAvaliacaoFisicaNegocio
    {
        void CriarAvaliacaoFisica(AvaliacaoFisicaEntidade avaliacao);
        IAvaliacaoFisicaRepositorio GetRepositorio();
    }
}
