using Chronos.Avaliacao.Conexao;
using Chronos.Avaliacao.Entidade.Agendamentos;
using Chronos.Avaliacao.Repositorio.Inteface.Agendamento;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;
using Microsoft.AspNetCore.Mvc;

namespace Chronos.Avaliacao.Repositorio.Agendamentos
{
    internal class MensagemRepositorio : IMensagemRepositorio
    {
        private readonly IGenerico _generico;
        private readonly Contexto _context;
        public MensagemRepositorio(IGenerico generico, Contexto context)
        {
            _generico = generico;
            _context = context;
        }
        public void SalvarMensagem(MensagemEntidade mensagem)
        {
            _generico.Salvar<MensagemEntidade>(mensagem);
        }
        public void RemoverMensagem(int Id)
        {
            _generico.Excluir<MensagemEntidade>(Id);
        }
        public void EditarMensagem(MensagemEntidade mensagem)
        {
            _generico.Editar<MensagemEntidade>(mensagem, mensagem.Id);
        }
        public IEnumerable<MensagemEntidade> BuscarMensagemPorAgendamento(int idCliente, int idAgendamento)
        {
            return _context.Mensagens.Where(m => m.IdCliente == idCliente && m.idAgendamento == idAgendamento).ToList();
        }
    }
}
