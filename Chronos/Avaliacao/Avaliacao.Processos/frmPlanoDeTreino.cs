using Chronos.Avaliacao.Avaliacao.Relatorio;
using Chronos.Avaliacao.DTO.Cadastros;
using Chronos.Avaliacao.DTO.PosAvaliacao;
using Chronos.Genericos;
using Chronos.Genericos.Cadastros.Mapeamento;
using Chronos.Genericos.Crud;
using Newtonsoft.Json;
using System.Data;

namespace Chronos.Avaliacao.Avaliacao.Processos
{
    public partial class frmPlanoDeTreino : Form
    {
        private readonly relPlanoDeTreino _relPlanotreino = new();
        private readonly MapperarPlanoDeTreinoDto _mappear = new();
        private readonly MetodosComuns _comuns = new();
        private readonly CrudGenerico _crud = new();
        private List<PlanoTreinoDTO> _listaPlanoTreino { get; set; }
        private int IdExercicioSelecionado { get; set; }
        public frmPlanoDeTreino()
        {
            InitializeComponent();
            ListarExercicios();
            _listaPlanoTreino = new();
            ListarPlanoTreino(_listaPlanoTreino);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void frmPlanoDeTreino_Load(object sender, EventArgs e)
        {
            _comuns.PreencherComboBoxAleatorio(cbmCliente, await _comuns.ListarDados<ClienteDTO>(URL.UrlCliente()), "Nome", "Id");
        }
        private async void ListarExercicios()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(URL.UrlExercicio());

                    if (response.IsSuccessStatusCode)
                    {
                        string resposta = await response.Content.ReadAsStringAsync();

                        List<ExercicioDTO> exercicioRecuperados = JsonConvert.DeserializeObject<List<ExercicioDTO>>(resposta);
                        gridExercicios.DataSource = exercicioRecuperados.OrderBy(e => e.Id).Select(e => new
                        {
                            Código = e.Id,
                            Exercicio = e.Nome,
                        }).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Erro na solicitação à API. Código de status: " + response.StatusCode, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar a API: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListarPlanoTreino(List<PlanoTreinoDTO> listaEntrada)
        {
            gridExercicios.RowHeadersWidth = 200;
            if (listaEntrada != null)
            {
                gridTreino.DataSource = listaEntrada.OrderBy(e => e.Id).Select(e => new
                {
                    Código = e.ExercicioId,
                    Nome = e.NomeExercicio,
                    Séries = e.Series,
                    repetições = e.Repeticoes
                }).ToList();
            }
            else
            {
                var lista = new List<PlanoTreinoDTO>();
                gridTreino.DataSource = lista.Select(e => new
                {
                    Código = "",
                    Nome = "",
                    Séries = "",
                    Repetições = ""
                }).ToList();
            }
        }

        private async void gridExercicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridExercicios.Rows[e.RowIndex];
                var recuperaCodigo = row.Cells["Código"].Value.ToString();
                IdExercicioSelecionado = Convert.ToInt32(recuperaCodigo);

                var api = URL.UrlExercicio() + "/" + recuperaCodigo;

                try
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        HttpResponseMessage response = await httpClient.GetAsync(api);

                        if (response.IsSuccessStatusCode)
                        {
                            string resposta = await response.Content.ReadAsStringAsync();

                            ExercicioDTO exercicioRecuperado = JsonConvert.DeserializeObject<ExercicioDTO>(resposta);

                            txtExercicio.Text = exercicioRecuperado.Nome;

                        }
                        else
                        {
                            MessageBox.Show("Erro na solicitação à API. Código de status: " + response.StatusCode, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar a API: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdicionarExercicio_Click(object sender, EventArgs e)
        {
            if (txtExercicio.Text.Equals(string.Empty))
            {
                MessageBox.Show("Selecione um exercício primeiro para inserir na montagem do seu treino", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var planoTreinoEntrada = new PlanoTreinoDTO();
                planoTreinoEntrada.ExercicioId = IdExercicioSelecionado;
                planoTreinoEntrada.NomeExercicio = txtExercicio.Text;
                planoTreinoEntrada.Repeticoes = (int)txtRepeticoes.Value;
                planoTreinoEntrada.Series = (int)txtSeries.Value;
                planoTreinoEntrada.IdCliente = (int)cbmCliente.SelectedValue;
                _listaPlanoTreino.Add(planoTreinoEntrada);
                ListarPlanoTreino(_listaPlanoTreino);
                txtExercicio.Text = string.Empty;
            }
        }

        private async void btnGerarAvaliacao_Click(object sender, EventArgs e)
        {
            _relPlanotreino.CriarRelatorioPlanoDeTreino(_listaPlanoTreino);
            var buscarIdDoTreino = await _mappear.BuscaIdDoTreinoAtual((int)cbmCliente.SelectedValue);
            foreach (var lista in _listaPlanoTreino)
            {
                lista.IdDoTreino = buscarIdDoTreino;
                _crud.Salvar(URL.UrlPlanoTreinoPost(), JsonConvert.SerializeObject(lista));
            }
        }

        private void gridExercicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
