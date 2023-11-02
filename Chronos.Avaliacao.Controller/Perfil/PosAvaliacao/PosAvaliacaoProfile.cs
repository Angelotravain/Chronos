using AutoMapper;
using Chronos.Avaliacao.DTO.PosAvaliacao;
using Chronos.Avaliacao.Entidade.PosAvaliacao;

namespace Chronos.Avaliacao.Controller.Perfil.PosAvaliacao
{
    public class PosAvaliacaoProfile : Profile
    {
        public PosAvaliacaoProfile()
        {
            CreateMap<PlanoTreinoDTO, PlanoTreinoEntidade>();
        }
    }
}
