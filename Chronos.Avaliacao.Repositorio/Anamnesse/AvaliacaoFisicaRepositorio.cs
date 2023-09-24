using Chronos.Avaliacao.Conexao;
using Chronos.Avaliacao.Entidade.Anamnese;
using Chronos.Avaliacao.Repositorio.Inteface.Anamnesse;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;

namespace Chronos.Avaliacao.Repositorio.Anamnesse
{
    internal class AvaliacaoFisicaRepositorio : IAvaliacaoFisicaRepositorio
    {
        private readonly Contexto _context;
        private readonly IGenerico _generico;
        public AvaliacaoFisicaRepositorio(Contexto context, IGenerico generico)
        {
            _context = context;
            _generico = generico;
        }
        public IEnumerable<AvaliacaoFisicaEntidade> RetornaTodasAsAvaliacoes()
        {
            return _context.AvaliacoesFisicas;
        }
        public AvaliacaoFisicaEntidade RetornaAvaliacaoPorCliente(int IdCliente)
        {
            return _context.AvaliacoesFisicas
                .Where(a => a.IdCliente == IdCliente)
                .OrderByDescending(a => a.Id)
                .FirstOrDefault();
        }
        public void CriarAvaliacaoFisica(AvaliacaoFisicaEntidade avaliacao)
        {
            _generico.Salvar<AvaliacaoFisicaEntidade>(avaliacao);
        }
    }
}
