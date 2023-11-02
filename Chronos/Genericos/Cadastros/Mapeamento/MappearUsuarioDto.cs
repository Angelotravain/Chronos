using Chronos.Avaliacao.DTO.Cadastros;

namespace Chronos.Genericos.Cadastros.Mapeamento
{
    public class MappearUsuarioDto
    {
        private readonly MetodosComuns _metodosComuns = new();
        public UsuarioDTO ObtenhaDadosAtualizadosDoUsuario(string id, string senhaSelecionada, bool editarUsuario, string usuarioEntrada, string senha, string nivelDeAcesso)
        {
            UsuarioDTO usuario = new();
            if (editarUsuario)
                usuario.Id = Convert.ToInt32(id);

            usuario.NomeUsuario = usuarioEntrada;

            if (senhaSelecionada != senha)
                usuario.Senha = _metodosComuns.RetornaSenhaCriptografada(senha);
            else
                usuario.Senha = senhaSelecionada;

            usuario.NivelAcesso = nivelDeAcesso;

            return usuario;
        }
    }
}
