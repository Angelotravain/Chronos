using Chronos.Avaliacao.Entidade.Agendamentos;

namespace Chronos.Avaliacao.Repositorio.Inteface.Agendamento
{
    public interface IMensagemRepositorio
    {
        IEnumerable<MensagemEntidade> BuscarMensagemPorAgendamento(int idCliente, int idAgendamento);
        void EditarMensagem(MensagemEntidade mensagem);
        void RemoverMensagem(int Id);
        void SalvarMensagem(MensagemEntidade mensagem);
    }
}
