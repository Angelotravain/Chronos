using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.DTO.PosAvaliacao
{
    public class PlanoTreinoDTO
    {
        public int Id { get; set; }
        public int ExercicioId { get; set; }
        public int ClienteId { get; set; }
        public int? Series { get; set; }
        public int? DuracaoEmMinutos { get; set; }
        public int? IntervaloEmSegundos { get; set; }
    }
}
