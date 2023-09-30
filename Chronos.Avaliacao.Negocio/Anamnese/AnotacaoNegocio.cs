using Chronos.Avaliacao.Negocio.Interface.Anamnese;
using Chronos.Avaliacao.Repositorio.Inteface.Anamnesse;

namespace Chronos.Avaliacao.Negocio.Anamnese
{
    internal class AnotacaoNegocio : IAnotacaoNegocio
    {
        private readonly IAnotacaoRepositorio _anotacaoRepositorio;
        public AnotacaoNegocio(IAnotacaoRepositorio anotacaoRepositorio)
        {
            _anotacaoRepositorio = anotacaoRepositorio;
        }
        public IAnotacaoRepositorio GetRepositorio() { return _anotacaoRepositorio; }
    }
}
