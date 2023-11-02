using Chronos.Avaliacao.Entidade.Agendamentos;
using Chronos.Avaliacao.Negocio.Interface.Agendamentos;
using Chronos.Avaliacao.Repositorio.Inteface.Agendamento;

namespace Chronos.Avaliacao.Negocio.Agendamentos
{
    internal class AgendamentoNegocio : IAgendamentoNegocio
    {
        private readonly IAgendamentoRepositorio _repositorio;
        public AgendamentoNegocio(IAgendamentoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public string SalvarAgendamento(AgendamentoEntidade agendamento)
        {
            var retorno = string.Empty;
            var agendamentos = _repositorio.ListarAgendamentosEmAbertoPorCliente(agendamento.IdCliente);
            foreach (var agendamentoAtual in agendamentos)
            {
                if ((agendamentoAtual.DataHoraDoAgendamento >= agendamento.DataHoraDoAgendamento))
                    retorno = $"Esse cliente jé está agendado para a data {agendamentoAtual.DataHoraDoAgendamento.ToString("dd/MM/yyyy")}";
            }
            if (string.IsNullOrEmpty(retorno))
                retorno = _repositorio.SalvarAgendamento(agendamento);

            return retorno;
        }
        public string ExcluirAgendamento(int Id)
        {
            return _repositorio.RemoverAgendamento(Id);
        }
        public string EditarAgendamento(AgendamentoEntidade agendamento)
        {
            var retorno = string.Empty;
            var agendamentos = _repositorio.ListarAgendamentosEmAbertoPorCliente(agendamento.IdCliente);
            foreach (var agendamentoAtual in agendamentos)
            {
                if ((agendamentoAtual.DataHoraDoAgendamento >= agendamento.DataHoraDoAgendamento))
                    retorno = $"Esse cliente jé está agendado para a data {agendamentoAtual.DataHoraDoAgendamento.ToString("dd/MM/yyyy")}";
            }
            if (string.IsNullOrEmpty(retorno))
                retorno = _repositorio.EditarAgendamento(agendamento);

            return retorno;
        }
        public IEnumerable<AgendamentoEntidade> ListarTodosOsAgendamentos()
        {
            return _repositorio.ListarTodosOsAgendamentos();
        }
        public AgendamentoEntidade ListarHistoricoAgendamentoCliente(int id)
        {
            return _repositorio.ListarHistoricoAgendamentoCliente(id);
        }
        public IEnumerable<AgendamentoEntidade> ListarAgendamentosEmAbertoPorCliente(int idCliente)
        {
            return _repositorio.ListarAgendamentosEmAbertoPorCliente(idCliente);
        }
        public bool BuscarAgendamentoPorId(int id)
        {
            return _repositorio.BuscarAgendamentoPorId(id);
        }
    }
}
