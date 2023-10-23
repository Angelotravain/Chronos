using Chronos.Avaliacao.Entidade.PosAvaliacao;
using Chronos.Avaliacao.Negocio.Interface.PosAvaliacao;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;
using Chronos.Avaliacao.Repositorio.Inteface.PosAvaliacao;

namespace Chronos.Avaliacao.Negocio.PosAvaliacao
{
    internal class PlanoTreinoNegocio : IPlanoTreinoNegocio
    {
        private readonly IPlanoTreinoRepositorio _planoTreinoRepositorio;
        private readonly IGenerico _classeGenerica;
        public PlanoTreinoNegocio(IPlanoTreinoRepositorio planoTreinoRepositorio, IGenerico classeGenerica)
        {
            _planoTreinoRepositorio = planoTreinoRepositorio;
            _classeGenerica = classeGenerica;
        }
        public IEnumerable<PlanoTreinoEntidade> BuscarTodosPlanosDeTreinoPorAluno(int idCliente)
        {
            return _planoTreinoRepositorio.BuscarPlanoTreinoPorIdCliente(idCliente);
        }
        public bool SalvarPlanoTreino(PlanoTreinoEntidade planoTreino)
        {
            _classeGenerica.Salvar<PlanoTreinoEntidade>(planoTreino);

            return true;
        }
        public bool EditarPlanoTreino(PlanoTreinoEntidade planoTreino)
        {
            _classeGenerica.Editar<PlanoTreinoEntidade>(planoTreino, planoTreino.Id);

            return true;
        }
    }
}
