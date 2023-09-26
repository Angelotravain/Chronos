using Chronos.Avaliacao.Entidade.Cadastros;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.Agendamentos
{
    [Table("agendamento")]
    public class AgendamentoEntidade
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("idcliente")]
        public int IdCliente { get; set; }

        [Column("datahoradoagendamento")]
        public DateTime DataHoraDoAgendamento { get; set; }

        [Column("statusdoagendamento")]
        public string? StatusDoAgendamento { get; set; }

        [NotMapped]
        public ICollection<ClienteEntidade>? Clientes { get; set; }
    }
}