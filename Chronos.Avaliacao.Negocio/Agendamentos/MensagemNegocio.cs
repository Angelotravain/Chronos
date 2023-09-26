using Chronos.Avaliacao.Negocio.Interface.Agendamentos;
using Chronos.Avaliacao.Repositorio.Inteface.Agendamento;

namespace Chronos.Avaliacao.Negocio.Agendamentos
{
    internal class MensagemNegocio : IMensagemNegocio
    {
        private readonly IMensagemRepositorio _repositorio;
        public MensagemNegocio(IMensagemRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public IMensagemRepositorio GetRepositorio() { return _repositorio; }
    }
}
