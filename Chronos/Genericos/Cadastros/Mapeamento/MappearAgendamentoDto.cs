using Chronos.Avaliacao.DTO.Agendamentos;

namespace Chronos.Genericos.Cadastros.Mapeamento
{
    public class MappearAgendamentoDto
    {
        public AgendamentoDTO ObtenhaDadosAtualizadosDoAgendamento(string id, bool editarAgendamento, int idCliente, DateTime dataHoraDoAgendamento, string statusAgendamento, string horaAgendamento, string mensagem)
        {
            AgendamentoDTO agendamento = new();
            if (editarAgendamento)
                agendamento.Id = Convert.ToInt32(id);

            agendamento.IdCliente = idCliente;
            agendamento.DataHoraDoAgendamento = dataHoraDoAgendamento.ToUniversalTime();
            agendamento.StatusDoAgendamento = statusAgendamento;
            agendamento.HoraAgendamento = horaAgendamento;
            agendamento.MensagemAgendamento = mensagem;

            return agendamento;
        }
    }
}
