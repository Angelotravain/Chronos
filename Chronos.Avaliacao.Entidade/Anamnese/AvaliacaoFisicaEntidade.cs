using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.Anamnese
{
    [Table("avaliacoesfisicas")]
    public class AvaliacaoFisicaEntidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("idcliente")]
        public int IdCliente { get; set; }

        [Column("dataavaliacao")]
        public DateTime DataAvaliacao { get; set; }

        [Column("peso")]
        public decimal Peso { get; set; }

        [Column("altura")]
        public decimal Altura { get; set; }

        [Column("pesoemgordura")]
        public decimal? PesoEmGordura { get; set; }

        [Column("imc")]
        public decimal? Imc { get; set; }

        [Column("circunferenciaabdomen")]
        public decimal CircunferenciaAbdomen { get; set; }

        [Column("porcentagemgordura")]
        public decimal PorcentagemGordura { get; set; }

        [Column("massamuscular")]
        public decimal? MassaMuscular { get; set; }

        [Column("objetivos")]
        public string? Objetivos { get; set; }

        [Column("circunferenciatriceptal")]
        public decimal CircunferenciaTriceptal { get; set; }

        [Column("circunferenciasuprailiaca")]
        public decimal CircunferenciaSuprailiaca { get; set; }
    }
}
