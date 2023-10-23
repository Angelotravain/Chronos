namespace Chronos.Avaliacao.DTO.Anamnese
{
    public class AvaliacaoFisicaDTO
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public decimal? PesoEmGordura { get; set; }
        public decimal? Imc { get; set; }
        public decimal CircunferenciaAbdomen { get; set; }
        public decimal PorcentagemGordura { get; set; }
        public decimal? MassaMuscular { get; set; }
        public string? Objetivos { get; set; }
        public decimal CircunferenciaTriceptal { get; set; }
        public decimal CircunferenciaSuprailiaca { get; set; }
    }
}
