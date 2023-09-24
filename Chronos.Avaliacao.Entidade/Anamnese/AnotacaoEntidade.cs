using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.Anamnese
{
    [Table("anotacoes")]
    public class AnotacaoEntidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("idcliente")]
        public int IdCliente { get; set; }

        [Column("datanota")]
        public DateTime? DataNota { get; set; }

        [Column("conteudonota")]
        public string? ConteudoNota { get; set; }
    }
}
