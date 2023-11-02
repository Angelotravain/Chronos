using Chronos.Avaliacao.Repositorio.Agendamentos;
using Chronos.Avaliacao.Repositorio.Anamnesse;
using Chronos.Avaliacao.Repositorio.Cadastros;
using Chronos.Avaliacao.Repositorio.Generico;
using Chronos.Avaliacao.Repositorio.Inteface.Agendamento;
using Chronos.Avaliacao.Repositorio.Inteface.Anamnesse;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;
using Chronos.Avaliacao.Repositorio.Inteface.PosAvaliacao;
using Chronos.Avaliacao.Repositorio.PosAvaliacao;
using Microsoft.Extensions.DependencyInjection;

namespace Chronos.Avaliacao.Repositorio.Containers
{
    public static class RepositorioContainer
    {
        public static IServiceCollection AddRepositorios(this IServiceCollection services)
        {
            services.AddTransient<IAgendamentoRepositorio, AgendamentoRepositorio>();

            #region Injeção Repositório
            services.AddTransient<IAgendamentoRepositorio, AgendamentoRepositorio>();
            services.AddTransient<IAvaliacaoFisicaRepositorio, AvaliacaoFisicaRepositorio>();
            services.AddTransient<IClienteRepositorio, ClienteRepositorio>();
            services.AddTransient<IExercicioRepositorio, ExercicioRepositorio>();
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddTransient<IGenerico, GenericoRepositorio>();
            services.AddTransient<IPlanoTreinoRepositorio, PlanoTreinoRepositorio>();

            #endregion

            return services;
        }
    }
}
