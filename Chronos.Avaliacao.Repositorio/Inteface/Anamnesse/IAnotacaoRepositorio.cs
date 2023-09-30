using Chronos.Avaliacao.Entidade.Anamnese;

namespace Chronos.Avaliacao.Repositorio.Inteface.Anamnesse
{
    public interface IAnotacaoRepositorio
    {
        IEnumerable<AnotacaoEntidade> BuscarAnotacaoPorAvaliacao(int idAvaliacao);
        string SalvarAnotacao(AnotacaoEntidade agendamento);
        string EditarAnotacao(AnotacaoEntidade agendamento);
        string ExcluirAnotacao(int id);
    }
}
