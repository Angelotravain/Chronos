using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.Cadastros
{
    [Table("exercicios")]
    public class ExercicioEntidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string? Nome { get; set; }

        [Column("grupomuscular")]
        public string? GrupoMuscular { get; set; }

        [Column("intensidade")]
        public string? Intensidade { get; set; }

        [Column("imagem_exercicio")]
        public byte[]? ImagemExercicio { get; set; }
    }
}
