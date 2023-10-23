using Chronos.Avaliacao.Entidade.Cadastros;

namespace Chronos.Avaliacao.Negocio.Interface.Cadastros
{
    public interface IUsuarioNegocio
    {
        void SalvarUsuario(UsuarioEntidade usuario);
        void EditarUsuario(UsuarioEntidade usuario);
        void ExcluirUsuario(int idUsuario);
        IEnumerable<UsuarioEntidade> BuscarTodosOsUsuarios();
        IEnumerable<UsuarioEntidade> BuscarUsuarioPorId(int id);
        IEnumerable<UsuarioEntidade> BuscarUsuarioPorNome(string nome);
    }
}
