using AutoMapper;
using Chronos.Avaliacao.DTO.Cadastros;
using Chronos.Avaliacao.Entidade.Cadastros;

namespace Chronos.Avaliacao.Controller.Perfil.Cadastros
{
    public class CadastrosProfile : Profile
    {
        public CadastrosProfile()
        {
            CreateMap<ClienteDTO, ClienteEntidade>();
            CreateMap<ExercicioDTO, ExercicioEntidade>();
            CreateMap<FuncionarioDTO, FuncionarioEntidade>();
            CreateMap<UsuarioDTO, UsuarioEntidade>();
        }
    }
}
