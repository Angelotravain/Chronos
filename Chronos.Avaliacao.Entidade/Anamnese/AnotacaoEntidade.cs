using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.Anamnese
{
    [Table("notas")]
    public class AnotacaoEntidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("idavaliacao")]
        public int IdAvaliacao { get; set; }

        [Column("datanota")]
        public DateTime? DataNota { get; set; }

        [Column("conteudonota")]
        public string? ConteudoNota { get; set; }
    }
}
