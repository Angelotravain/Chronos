using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Negocio.Interface.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;

namespace Chronos.Avaliacao.Negocio.Cadastros
{
    internal class UsuarioNegocio : IUsuarioNegocio
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IGenerico _classeGenerica;
        public UsuarioNegocio(IUsuarioRepositorio usuarioRepositorio, IGenerico classeGenerica)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _classeGenerica = classeGenerica;
        }
        public void SalvarUsuario(UsuarioEntidade usuario)
        {
            _classeGenerica.Salvar<UsuarioEntidade>(usuario);
        }
        public void EditarUsuario(UsuarioEntidade usuario)
        {
            _classeGenerica.Editar<UsuarioEntidade>(usuario, usuario.Id);
        }
        public void ExcluirUsuario(int idUsuario)
        {
            _classeGenerica.Excluir<UsuarioEntidade>(idUsuario);
        }
        public IEnumerable<UsuarioEntidade> BuscarTodosOsUsuarios()
        {
            return _usuarioRepositorio.BuscarTodosOsUsuarios();
        }
        public IEnumerable<UsuarioEntidade> BuscarUsuarioPorId(int id)
        {
            return _usuarioRepositorio.BuscarUsuarioPorId(id);
        }
        public IEnumerable<UsuarioEntidade> BuscarUsuarioPorNome(string nome)
        {
            return _usuarioRepositorio.BuscarUsuarioPorNome(nome);
        }
    }
}
