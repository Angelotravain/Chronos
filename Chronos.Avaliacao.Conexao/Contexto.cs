using Chronos.Avaliacao.Entidade.Agendamentos;
using Chronos.Avaliacao.Entidade.Anamnese;
using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Entidade.Financeiro;
using Chronos.Avaliacao.Entidade.PosAvaliacao;
using Microsoft.EntityFrameworkCore;

namespace Chronos.Avaliacao.Conexao
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<AgendamentoEntidade> Agendamentos { get; set; }
        public DbSet<AnotacaoEntidade> Anotacoes { get; set; }
        public DbSet<AvaliacaoFisicaEntidade> AvaliacoesFisicas { get; set; }
        public DbSet<ClienteEntidade> Clientes { get; set; }
        public DbSet<ExercicioEntidade> Exercicios { get; set; }
        public DbSet<FuncionarioEntidade> Funcionarios { get; set; }
        public DbSet<MensagemEntidade> Mensagens { get; set; }
        public DbSet<PagamentoEntidade> Pagamentos { get; set; }
        public DbSet<PlanoTreinoEntidade> PlanosDeTreino { get; set; }
        public DbSet<TreinoEntidade> Treinos { get; set; }
        public DbSet<UsuarioEntidade> Ususarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host = localhost; Port = 5432; Database = CRM_AVALIACAO; Username = postgres; Password = postgres;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}