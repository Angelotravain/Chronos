using AutoMapper;
using Chronos.Avaliacao.DTO.Agendamentos;
using Chronos.Avaliacao.Entidade.Agendamentos;

namespace Chronos.Avaliacao.Controller.Perfil.Agendamentos
{
    public class AgendamentoProfile : Profile
    {
        public AgendamentoProfile()
        {
            CreateMap<AgendamentoDTO, AgendamentoEntidade>();
            CreateMap<HorarioDisponivelDTO, HorarioDisponivelEntidade>();
            CreateMap<MensagemDTO, MensagemEntidade>();
        }
    }
}

