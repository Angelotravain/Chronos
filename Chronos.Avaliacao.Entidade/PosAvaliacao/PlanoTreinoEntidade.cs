using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.PosAvaliacao
{
    [Table("planodetreino")]
    public class PlanoTreinoEntidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("exercicioid")]
        public int ExercicioId { get; set; }

        [Column("series")]
        public int? Series { get; set; }

        [Column("repeticoes")]
        public int? Repeticoes { get; set; }

        [Column("nome_exercicio")]
        public string? NomeExercicio { get; set; }

    }
}
