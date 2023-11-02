using Chronos.Avaliacao.Avaliacao.Relatorio;
using Chronos.Avaliacao.DTO.Cadastros;
using Chronos.Avaliacao.DTO.PosAvaliacao;
using Chronos.Genericos;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;

namespace Chronos.Avaliacao.Avaliacao.Processos
{
    public partial class frmPlanoDeTreino : Form
    {
        private readonly AjustarComponentes _ajustarComponentes = new();
        private readonly relPlanoDeTreino _relPlanotreino = new relPlanoDeTreino();
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

        private void frmPlanoDeTreino_Load(object sender, EventArgs e)
        {

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
            var planoTreinoEntrada = new PlanoTreinoDTO();
            planoTreinoEntrada.ExercicioId = IdExercicioSelecionado;
            planoTreinoEntrada.NomeExercicio = txtExercicio.Text;
            planoTreinoEntrada.Repeticoes = (int)txtRepeticoes.Value;
            planoTreinoEntrada.Series = (int)txtSeries.Value;
            _listaPlanoTreino.Add(planoTreinoEntrada);
            ListarPlanoTreino(_listaPlanoTreino);
        }

        private void btnGerarAvaliacao_Click(object sender, EventArgs e)
        {
            _relPlanotreino.CriarRelatorioPlanoDeTreino(_listaPlanoTreino);
        }

        private void gridExercicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
