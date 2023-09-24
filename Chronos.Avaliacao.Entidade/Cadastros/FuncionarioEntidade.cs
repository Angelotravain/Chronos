using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.Cadastros
{
    [Table("funcionarios")]
    public class FuncionarioEntidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string? Nome { get; set; }

        [Column("sobrenome")]
        public string? Sobrenome { get; set; }

        [Column("cargo")]
        public string? Cargo { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("numerodetelefone")]
        public string? NumeroDeTelefone { get; set; }
    }
}
