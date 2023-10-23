using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.DTO.PosAvaliacao
{
    public class TreinoDTO
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int PlanoTreinoId { get; set; }
        public DateTime? DataTreino { get; set; }
        public string? DescricaoTreino { get; set; }
        public string? Progresso { get; set; }
    }
}
