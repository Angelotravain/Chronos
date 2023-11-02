using Chronos.Avaliacao.Avaliacao.Relatorio;
using Chronos.Avaliacao.DTO.Agendamentos;
using Chronos.Avaliacao.DTO.Anamnese;
using Chronos.Genericos.Cadastros.Mapeamento;
using Chronos.Genericos.Crud;
using Newtonsoft.Json;

namespace Chronos.Avaliacao.Avaliacao.Processos
{
    public partial class frmAvaliacaoFisica : Form
    {
        private int CodigoClienteRecebido { get; set; }
        private string apiUrl = URL.UrlAvaliacao();
        private readonly string apiUrlAgendamento = URL.UrlAgendamento();

        private readonly MappearAvaliacaoDto _mapperAvaliacao = new();
        private readonly CrudGenerico _crudGenerico = new();
        private readonly AgendamentoDTO _agendamentoDTO;
        private readonly relAvaliacaoFisica _avaliacaoFisica = new();
        public frmAvaliacaoFisica(AgendamentoDTO agendamento, int codigoCliente = 0)
        {
            InitializeComponent();
            CodigoClienteRecebido = codigoCliente;
            _agendamentoDTO = agendamento;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void btnGerarAvaliacao_Click(object sender, EventArgs e)
        {
            List<AvaliacaoFisicaDTO> listaAvaliacao = new();
            string jsonSalvar = JsonConvert.SerializeObject(_mapperAvaliacao.ObtenhaDadosAtualizadosAvaliacao(CodigoClienteRecebido.ToString(), txtPeso.Value, txtAltura.Value, txtCircAbdominal.Value, txtCircSupra.Value, txtCircTtriceps.Value, txtObjetivo.Text));
            AvaliacaoFisicaDTO avaliacao = JsonConvert.DeserializeObject<AvaliacaoFisicaDTO>(await _crudGenerico.Salvar(apiUrl, jsonSalvar));
            listaAvaliacao.Add(avaliacao);
            _avaliacaoFisica.CriarRelatorioAvaliacao(listaAvaliacao);

            _agendamentoDTO.StatusDoAgendamento = "Realizado";
            string jsonAgendamento = JsonConvert.SerializeObject(_agendamentoDTO);
            _crudGenerico.Editar($"{apiUrlAgendamento}/{_agendamentoDTO.Id}", jsonAgendamento);
        }

        private void frmAvaliacaoFisica_Load(object sender, EventArgs e)
        {

        }
    }
}
