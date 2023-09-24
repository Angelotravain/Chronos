namespace Chronos.Avaliacao.DTO.Agendamentos
{
    public class HorarioDisponivelDTO
    {
        public int Id { get; set; }

        public int IdFuncionario { get; set; }
        public string? DiaDaSemana { get; set; }
        public TimeSpan HoraDeInicio { get; set; }
        public TimeSpan HoraDeTermino { get; set; }
        public bool Disponibilidade { get; set; }
    }
}
