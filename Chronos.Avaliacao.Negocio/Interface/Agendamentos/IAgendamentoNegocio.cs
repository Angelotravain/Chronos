using Chronos.Avaliacao.Entidade.Agendamentos;

namespace Chronos.Avaliacao.Negocio.Interface.Agendamentos
{
    public interface IAgendamentoNegocio
    {
        string SalvarAgendamento(AgendamentoEntidade agendamento);
        string ExcluirAgendamento(int Id);
        string EditarAgendamento(AgendamentoEntidade agendamento);
        IEnumerable<AgendamentoEntidade> ListarTodosOsAgendamentos();
        IEnumerable<AgendamentoEntidade> ListarHistoricoAgendamentoCliente(int idCliente);
        IEnumerable<AgendamentoEntidade> ListarAgendamentosEmAbertoPorCliente(int idCliente);
        bool BuscarAgendamentoPorId(int id);
    }
}
