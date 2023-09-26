using Chronos.Avaliacao.Conexao;
using Chronos.Avaliacao.Entidade.Agendamentos;
using Chronos.Avaliacao.Repositorio.Inteface.Agendamento;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;

namespace Chronos.Avaliacao.Repositorio.Agendamentos
{
    internal class AgendamentoRepositorio : IAgendamentoRepositorio
    {
        private readonly IGenerico _generico;
        private readonly Contexto _context;
        public AgendamentoRepositorio(IGenerico generico, Contexto context)
        {
            _generico = generico;
            _context = context;
        }
        public string SalvarAgendamento(AgendamentoEntidade agendamento)
        {
            _generico.Salvar<AgendamentoEntidade>(agendamento);

            return "Agendamento salvo com sucesso!";
        }
        public string RemoverAgendamento(int Id)
        {
            _generico.Excluir<AgendamentoEntidade>(Id);

            return "Agendamento removido com sucesso com sucesso!";
        }
        public string EditarAgendamento(AgendamentoEntidade agendamento)
        {
            _generico.Editar<AgendamentoEntidade>(agendamento, agendamento.Id);

            return "Agendamento editado com sucesso com sucesso!";
        }
        public IEnumerable<AgendamentoEntidade> ListarTodosOsAgendamentos()
        {
            return _context.Agendamentos.ToList();
        }
        public IEnumerable<AgendamentoEntidade> ListarAgendamentosEmAbertoPorCliente(int idCliente)
        {
            return _context.Agendamentos.Where(c => c.IdCliente == idCliente && c.StatusDoAgendamento.Equals("Em Aberto")).ToList();
        }
        public IEnumerable<AgendamentoEntidade> ListarHistoricoAgendamentoCliente(int idCliente)
        {
            return _context.Agendamentos.Where(c => c.IdCliente == idCliente).ToList();
        }
        public bool BuscarAgendamentoPorId(int id)
        {
            var agendamento = _context.Agendamentos.FirstOrDefault(a => a.Id == id);
            var boleano = false;
            if (agendamento == null)
                boleano = true;

            return boleano;
        }
    }
}
