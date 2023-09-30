using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.DTO.Anamnese
{
    public class AnotacaoDTO
    {
        public int Id { get; set; }
        public int IdAvaliacao { get; set; }
        public DateTime? DataNota { get; set; }
        public string? ConteudoNota { get; set; }
    }
}
