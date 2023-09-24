using Chronos.Avaliacao.Conexao;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;

namespace Chronos.Avaliacao.Repositorio.Generico
{
    internal class GenericoRepositorio : IGenerico
    {
        private readonly Contexto _context;
        public GenericoRepositorio(Contexto context)
        {
            _context = context;
        }
        public void Salvar<T>(T entidade) where T : class
        {
            _context.Set<T>().Add(entidade);
            _context.SaveChanges();
        }
        public void Editar<T>(T entidade, int id) where T : class
        {
            var existingEntity = _context.Set<T>().Find(id);

            if (existingEntity == null)
                throw new ArgumentException("A entidade não existe no banco de dados.", nameof(entidade));

            if (existingEntity.Equals(entidade))
                return;

            _context.Entry(existingEntity).CurrentValues.SetValues(entidade);
            _context.SaveChanges();
        }
        public void Excluir<T>(int id) where T : class
        {

            var entity = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
