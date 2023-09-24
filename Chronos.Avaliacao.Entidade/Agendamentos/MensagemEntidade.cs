using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.Agendamentos
{
    [Table("mensagens")]
    public class MensagemEntidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("idcliente")]
        public int IdCliente { get; set; }

        [Column("idfuncionario")]
        public int IdFuncionario { get; set; }

        [Column("datahoramensagem")]
        public DateTime DataHoraMensagem { get; set; }

        [Column("conteudodamensagem")]
        public string? ConteudoDaMensagem { get; set; }
    }
}
