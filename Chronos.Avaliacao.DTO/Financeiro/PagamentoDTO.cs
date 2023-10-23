namespace Chronos.Avaliacao.DTO.Financeiro
{
    public class PagamentoDTO
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal? ValorPagamento { get; set; }
        public string? StatusPagamento { get; set; }
    }
}
