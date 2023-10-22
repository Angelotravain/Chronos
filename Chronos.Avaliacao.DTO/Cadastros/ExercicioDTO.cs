using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.DTO.Cadastros
{
    public class ExercicioDTO
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? GrupoMuscular { get; set; }
        public string? Intensidade { get; set; }
        public byte[]? ImagemExercicio { get; set; }
    }
}
