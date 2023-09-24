using AutoMapper;
using Chronos.Avaliacao.DTO.Financeiro;
using Chronos.Avaliacao.Entidade.Financeiro;

namespace Chronos.Avaliacao.Controller.Perfil.Financeiro
{
    public class FinanceiroProfile : Profile
    {
        public FinanceiroProfile()
        {
            CreateMap<PagamentoDTO, PagamentoEntidade>();
        }
    }
}
