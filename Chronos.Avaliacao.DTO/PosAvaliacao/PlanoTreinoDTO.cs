namespace Chronos.Avaliacao.DTO.PosAvaliacao
{
    public class PlanoTreinoDTO
    {
        public int Id { get; set; }
        public int ExercicioId { get; set; }
        public int? Series { get; set; }
        public int? Repeticoes { get; set; }
        public string? NomeExercicio { get; set; }

    }
}
