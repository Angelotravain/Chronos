using Chronos.Avaliacao.Entidade.Agendamentos;

namespace Chronos.Avaliacao.Repositorio.Inteface.Agendamento
{
    public interface IAgendamentoRepositorio
    {
        AgendamentoEntidade ListarHistoricoAgendamentoCliente(int idCliente);
        IEnumerable<AgendamentoEntidade> ListarAgendamentosEmAbertoPorCliente(int idCliente);
        IEnumerable<AgendamentoEntidade> ListarTodosOsAgendamentos();
        string EditarAgendamento(AgendamentoEntidade agendamento);
        string RemoverAgendamento(int Id);
        string SalvarAgendamento(AgendamentoEntidade agendamento);
        bool BuscarAgendamentoPorId(int id);
    }
}
