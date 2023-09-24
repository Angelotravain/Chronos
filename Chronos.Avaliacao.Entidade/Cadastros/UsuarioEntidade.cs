using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.Cadastros
{
    [Table("usuarios")]
    public class UsuarioEntidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nomeusuario")]
        public string? NomeUsuario { get; set; }

        [Column("senha")]
        public string? Senha { get; set; }

        [Column("nivelacesso")]
        public string? NivelAcesso { get; set; }
    }
}
