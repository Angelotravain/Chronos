using Chronos.Avaliacao.Controller.Perfil.Agendamentos;
using Chronos.Avaliacao.Controller.Perfil.Anamnese;
using Chronos.Avaliacao.Controller.Perfil.Cadastros;
using Chronos.Avaliacao.Controller.Perfil.PosAvaliacao;
using Microsoft.Extensions.DependencyInjection;

namespace Chronos.Avaliacao.Controller.Perfil.Container
{
    public static class MapeamentoContainer
    {
        public static IServiceCollection AddMapeamentos(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AgendamentoProfile));
            services.AddAutoMapper(typeof(AnamneseProfile));
            services.AddAutoMapper(typeof(CadastrosProfile));
            services.AddAutoMapper(typeof(PosAvaliacaoProfile));

            return services;
        }
    }
}
