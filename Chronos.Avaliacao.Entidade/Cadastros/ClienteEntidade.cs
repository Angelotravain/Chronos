using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.Cadastros
{
    [Table("clientes")]
    public class ClienteEntidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string? Nome { get; set; }

        [Column("sobrenome")]
        public string? Sobrenome { get; set; }

        [Column("datanascimento")]
        public DateTime? DataNascimento { get; set; }

        [Column("endereco")]
        public string? Endereco { get; set; }

        [Column("numerotelefone")]
        public string? NumeroTelefone { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("dataingresso")]
        public DateTime? DataIngresso { get; set; }
    }
}
