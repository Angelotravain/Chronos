using Chronos.Avaliacao.Conexao;
using Chronos.Avaliacao.Entidade.Anamnese;
using Chronos.Avaliacao.Repositorio.Inteface.Anamnesse;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;

namespace Chronos.Avaliacao.Repositorio.Anamnesse
{
    internal class AnotacaoRepositorio : IAnotacaoRepositorio
    {
        private readonly Contexto _context;
        private readonly IGenerico _generico;
        public AnotacaoRepositorio(Contexto context, IGenerico generico)
        {
            _context = context;
            _generico = generico;
        }
        public string SalvarAnotacao(AnotacaoEntidade agendamento)
        {
            _generico.Salvar<AnotacaoEntidade>(agendamento);

            return "Anotação salvo com sucesso!";
        }
        public string EditarAnotacao(AnotacaoEntidade agendamento)
        {
            _generico.Editar<AnotacaoEntidade>(agendamento, agendamento.Id);

            return "Anotação editada com sucesso!";
        }
        public string ExcluirAnotacao(int id)
        {
            _generico.Excluir<AnotacaoEntidade>(id);

            return "Anotação excluida com sucesso!";
        }
        public IEnumerable<AnotacaoEntidade> BuscarAnotacaoPorAvaliacao(int idAvaliacao)
        {
            return _context.Anotacoes.Where( an => an.IdAvaliacao == idAvaliacao);
        }
    }
}
