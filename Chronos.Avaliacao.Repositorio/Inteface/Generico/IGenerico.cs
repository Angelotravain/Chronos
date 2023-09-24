namespace Chronos.Avaliacao.Repositorio.Inteface.Generico
{
    public interface IGenerico
    {
        void Salvar<T>(T entidade) where T : class;
        void Editar<T>(T entidade, int id) where T : class;
        void Excluir<T>(int id) where T : class;
    }
}
