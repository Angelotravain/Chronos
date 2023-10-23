using Chronos.Avaliacao.Entidade.Cadastros;

namespace Chronos.Avaliacao.Repositorio.Inteface.Cadastros
{
    public interface IUsuarioRepositorio
    {
        IEnumerable<UsuarioEntidade> BuscarTodosOsUsuarios();
        IEnumerable<UsuarioEntidade> BuscarUsuarioPorId(int id);
        IEnumerable<UsuarioEntidade> BuscarUsuarioPorNome(string nome);
    }
}
