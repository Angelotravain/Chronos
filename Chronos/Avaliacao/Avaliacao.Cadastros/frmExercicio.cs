using Chronos.Avaliacao.DTO.Cadastros;
using Chronos.Genericos;
using Chronos.Genericos.Cadastros.Mapeamento;
using Chronos.Genericos.Crud;
using Newtonsoft.Json;
using System.Data;

namespace Chronos.Avaliacao.Avaliacao.Cadastros
{
    public partial class frmExercicio : Form
    {
        private string IdExercicioSelecionado { get; set; }

        private readonly MetodosComuns _comuns = new();
        private readonly MappearExercicioDto _mappearExercicioDto = new();
        private readonly AjustarComponentes _ajustarComponentes = new();
        private readonly CrudGenerico _crudGenerico = new();
        private string apiUrl = URL.UrlExercicio();
        public frmExercicio()
        {
            InitializeComponent();
        }
        private void frmExercicio_Load(object sender, EventArgs e)
        {
            _ajustarComponentes.ajustarGrid(gridExercicio);
            ListarExercicios();
            IdExercicioSelecionado = string.Empty;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pcImagemExercicio_Click(object sender, EventArgs e)
        {
            _comuns.AbrirImagem(pcImagemExercicio);
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbmIntensidade.Text == string.Empty || cbmGrupoMuscular.Text == string.Empty)
                MessageBox.Show("Preencha os combobox para salvar um exercício!", "Atenção");
            else if (txtExercicio.Text == string.Empty)
                MessageBox.Show("Preencha o nome do exercício para salvar!", "Atenção");
            else
            {
                string jsonSalvar = JsonConvert.SerializeObject(_mappearExercicioDto.ObtenhaDadosAtualizadosDoExercicio("", false, txtExercicio.Text, cbmIntensidade.SelectedItem.ToString(), cbmGrupoMuscular.SelectedItem.ToString(), _comuns.ConverterImagemParaByte(pcImagemExercicio)));
                await _crudGenerico.Salvar(apiUrl, jsonSalvar);
                ListarExercicios();
                LimparCampos();
            }
        }
        private async void ListarExercicios()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string resposta = await response.Content.ReadAsStringAsync();

                        List<ExercicioDTO> exercicioRecuperados = JsonConvert.DeserializeObject<List<ExercicioDTO>>(resposta);
                        gridExercicio.DataSource = exercicioRecuperados.OrderBy(e => e.Id).Select(e => new
                        {
                            Código = e.Id,
                            Exercicio = e.Nome,
                            Intensidade = e.Intensidade
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

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbmIntensidade.Text == string.Empty || cbmGrupoMuscular.Text == string.Empty)
                MessageBox.Show("Preencha os combobox para salvar um exercício!", "Atenção");
            else if (txtExercicio.Text == string.Empty)
                MessageBox.Show("Preencha o nome do exercício para salvar!", "Atenção");
            else
            {

                int exercicioId = Convert.ToInt32(IdExercicioSelecionado);
                ExercicioDTO exercicioAtualizado = _mappearExercicioDto.ObtenhaDadosAtualizadosDoExercicio(IdExercicioSelecionado, true, txtExercicio.Text, cbmIntensidade.SelectedItem.ToString(), cbmGrupoMuscular.SelectedItem.ToString(), _comuns.ConverterImagemParaByte(pcImagemExercicio));

                var api = apiUrl + "/" + exercicioId;
                string json = JsonConvert.SerializeObject(exercicioAtualizado);
                _crudGenerico.Editar(api, json);
                MessageBox.Show("Exercicio editado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarExercicios();
                LimparCampos();
            }
        }

        private async void gridExercicio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridExercicio.Rows[e.RowIndex];
                var recuperaCodigo = row.Cells["Código"].Value.ToString();
                IdExercicioSelecionado = recuperaCodigo;

                var api = apiUrl + "/" + recuperaCodigo;

                try
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        HttpResponseMessage response = await httpClient.GetAsync(api);

                        if (response.IsSuccessStatusCode)
                        {
                            string resposta = await response.Content.ReadAsStringAsync();

                            ExercicioDTO usuarioRecuperado = JsonConvert.DeserializeObject<ExercicioDTO>(resposta);

                            PreencherCamposComExercicio(usuarioRecuperado);
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

        private void PreencherCamposComExercicio(ExercicioDTO? exercicioRecuperado)
        {
            if (exercicioRecuperado != null)
            {
                txtExercicio.Text = exercicioRecuperado.Nome;
                cbmGrupoMuscular.Text = exercicioRecuperado.GrupoMuscular;
                cbmIntensidade.Text = exercicioRecuperado.Intensidade;
                using (var ms = new MemoryStream(exercicioRecuperado.ImagemExercicio))
                {
                    Image imagemRecuperada = Image.FromStream(ms);
                    pcImagemExercicio.Image = new Bitmap(imagemRecuperada);
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (IdExercicioSelecionado == string.Empty)
                MessageBox.Show("Selecione um exercício para excluir", "Excluir");
            else
            {
                _crudGenerico.Deletar(apiUrl, Convert.ToInt32(IdExercicioSelecionado)).ToString();
                MessageBox.Show("Exercício excluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarExercicios();
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtExercicio.Text = string.Empty;
            cbmGrupoMuscular.Text = string.Empty;
            cbmIntensidade.Text = string.Empty;
            pcImagemExercicio.Image = Properties.Resources.sem_imagem;
        }
    }
}
