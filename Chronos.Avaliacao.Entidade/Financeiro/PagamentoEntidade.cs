using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.Financeiro
{
    [Table("pagamentos")]
    public class PagamentoEntidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("idcliente")]
        public int IdCliente { get; set; }

        [Column("datapagamento")]
        public DateTime? DataPagamento { get; set; }

        [Column("valorpagamento")]
        public decimal? ValorPagamento { get; set; }

        [Column("statuspagamento")]
        public string? StatusPagamento { get; set; }
    }
}
