using Chronos.Avaliacao.Negocio.Agendamentos;
using Chronos.Avaliacao.Negocio.Anamnese;
using Chronos.Avaliacao.Negocio.Cadastros;
using Chronos.Avaliacao.Negocio.Financeiro;
using Chronos.Avaliacao.Negocio.Interface.Agendamentos;
using Chronos.Avaliacao.Negocio.Interface.Anamnese;
using Chronos.Avaliacao.Negocio.Interface.Cadastros;
using Chronos.Avaliacao.Negocio.Interface.Financeiro;
using Chronos.Avaliacao.Negocio.Interface.PosAvaliacao;
using Chronos.Avaliacao.Negocio.PosAvaliacao;
using Microsoft.Extensions.DependencyInjection;

namespace Chronos.Avaliacao.Negocio.Container
{
    public static class NegocioContainer
    {
        public static IServiceCollection AddNegocios(this IServiceCollection services)
        {

            #region Injeção Negócios

            services.AddTransient<IAgendamentoNegocio, AgendamentoNegocio>();
            services.AddTransient<IHorarioDisponivelNegocio, HorarioDisponivelNegocio>();
            services.AddTransient<IMensagemNegocio, MensagemNegocio>();
            services.AddTransient<IAnotacaoNegocio, AnotacaoNegocio>();
            services.AddTransient<IAvaliacaoFisicaNegocio, AvaliacaoFisicaNegocio>();
            services.AddTransient<IClienteNegocio, ClienteNegocio>();
            services.AddTransient<IExercicioNegocio, ExercicioNegocio>();
            services.AddTransient<IFuncionarioNegocio, FuncionarioNegocio>();
            services.AddTransient<IUsuarioNegocio, UsuarioNegocio>();
            services.AddTransient<IPagamentoNegocio, PagamentoNegocio>();
            services.AddTransient<ITreinoNegocio, TreinoNegocio>();
            services.AddTransient<IPlanoTreinoNegocio, PlanoTreinoNegocio>();

            #endregion

            return services;
        }
    }
}
