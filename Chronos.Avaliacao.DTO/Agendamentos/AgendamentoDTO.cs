using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.DTO.Agendamentos
{
    public class AgendamentoDTO
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataHoraDoAgendamento { get; set; }
        public string? StatusDoAgendamento { get; set; }
    }
}
