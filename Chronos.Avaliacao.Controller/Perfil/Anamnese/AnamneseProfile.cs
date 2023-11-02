using AutoMapper;
using Chronos.Avaliacao.DTO.Anamnese;
using Chronos.Avaliacao.Entidade.Anamnese;

namespace Chronos.Avaliacao.Controller.Perfil.Anamnese
{
    public class AnamneseProfile : Profile
    {
        public AnamneseProfile()
        {
            CreateMap<AvaliacaoFisicaDTO, AvaliacaoFisicaEntidade>();
            CreateMap<AvaliacaoFisicaEntidade, AvaliacaoFisicaDTO>();
        }
    }
}
