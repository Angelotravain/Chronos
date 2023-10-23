using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.PosAvaliacao
{
    [Table("treinos")]
    public class TreinoEntidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("idcliente")]
        public int IdCliente { get; set; }

        [Column("planotreinoid")]
        public int PlanoTreinoId { get; set; }

        [Column("datatreino")]
        public DateTime? DataTreino { get; set; }

        [Column("descricaotreino")]
        public string? DescricaoTreino { get; set; }

        [Column("progresso")]
        public string? Progresso { get; set; }
    }
}
