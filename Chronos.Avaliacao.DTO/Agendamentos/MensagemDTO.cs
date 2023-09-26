namespace Chronos.Avaliacao.DTO.Agendamentos
{
    public class MensagemDTO
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdFuncionario { get; set; }
        public DateTime DataHoraMensagem { get; set; }
        public string? ConteudoDaMensagem { get; set; }
        public int idAgendamento { get; set; }
    }
}
