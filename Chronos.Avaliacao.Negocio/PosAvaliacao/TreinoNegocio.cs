using Chronos.Avaliacao.Entidade.PosAvaliacao;
using Chronos.Avaliacao.Negocio.Interface.PosAvaliacao;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;
using Chronos.Avaliacao.Repositorio.Inteface.PosAvaliacao;

namespace Chronos.Avaliacao.Negocio.PosAvaliacao
{
    internal class TreinoNegocio : ITreinoNegocio
    {
        private readonly ITreinoRepositorio _treinoRepositorio;
        private readonly IGenerico _classeGenerica;
        public TreinoNegocio(ITreinoRepositorio treinoRepositorio, IGenerico generico)
        {
            _treinoRepositorio = treinoRepositorio;
            _classeGenerica = generico;
        }
        public void SalvarTreino(TreinoEntidade treino)
        {
            _classeGenerica.Salvar<TreinoEntidade>(treino);
        }
        public void EditarTreino(TreinoEntidade treino)
        {
            _classeGenerica.Editar<TreinoEntidade>(treino, treino.Id);
        }
        public IEnumerable<TreinoEntidade> BuscarTreinosPorId(int id)
        {
            return _treinoRepositorio.BuscarTreinoPorId(id);
        }
        public IEnumerable<TreinoEntidade> BuscarTreinoPorIdCliente(int idCliente)
        {
            return _treinoRepositorio.BuscarTreinoPorIdCliente(idCliente);
        }
    }
}
