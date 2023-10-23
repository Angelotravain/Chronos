using Chronos.Avaliacao.Conexao;
using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;

namespace Chronos.Avaliacao.Repositorio.Cadastros
{
    internal class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Contexto _context;
        public UsuarioRepositorio(Contexto context)
        {
            _context = context;
        }
        public IEnumerable<UsuarioEntidade> BuscarTodosOsUsuarios()
        {
            return _context.Ususarios.ToList();
        }
        public IEnumerable<UsuarioEntidade> BuscarUsuarioPorId(int id)
        {
            return _context.Ususarios.Where(u => u.Id == id).ToList();
        }
        public IEnumerable<UsuarioEntidade> BuscarUsuarioPorNome(string nome)
        {
            return _context.Ususarios.Where(u => u.NomeUsuario == nome).ToList();
        }
    }
}
