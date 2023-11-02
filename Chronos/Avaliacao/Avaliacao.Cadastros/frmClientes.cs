using Chronos.Avaliacao.DTO.Cadastros;
using Chronos.Genericos;
using Chronos.Genericos.Cadastros.Mapeamento;
using Chronos.Genericos.Crud;
using Newtonsoft.Json;
using System.Data;

namespace Chronos.Avaliacao.Avaliacao.Cadastros
{
    public partial class frmClientes : Form
    {
        private string IdClienteSelecionado { get; set; }

        private AjustarComponentes _ajustarComponentes = new();
        private MappearClienteDto _mappearClienteDto = new();
        private CrudGenerico _crudGenerico = new();
        private string apiUrl = URL.UrlCliente();
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
            _crudGenerico = new();
            _mappearClienteDto = new();
            _ajustarComponentes = new();
            _ajustarComponentes.ajustarGrid(gridCliente);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            string jsonSalvar = JsonConvert.SerializeObject(_mappearClienteDto.ObtenhaDadosAtualizadosDoCliente("", false, txtNome.Text, txtEmail.Text, txtSobrenome.Text, txtTelefone.Text, txtEndereco.Text, txtDataNascimento.Value));
            await _crudGenerico.Salvar(apiUrl, jsonSalvar);
            ListarClientes();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            IdClienteSelecionado = string.Empty;
        }

        private async void ListarClientes()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string resposta = await response.Content.ReadAsStringAsync();

                        List<ClienteDTO> clientesRecuperados = JsonConvert.DeserializeObject<List<ClienteDTO>>(resposta);
                        gridCliente.DataSource = clientesRecuperados.OrderBy(c => c.Id).Select(c => new
                        {
                            Código = c.Id,
                            Cliente = c.Nome + " " + c.Sobrenome,
                            Nascimento = Convert.ToDateTime(c.DataNascimento).ToString("dd/MM/yyyy")
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

        private async void gridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridCliente.Rows[e.RowIndex];
                var recuperaCodigo = row.Cells["Código"].Value.ToString();
                IdClienteSelecionado = recuperaCodigo;

                var api = apiUrl + "/" + recuperaCodigo;

                try
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        HttpResponseMessage response = await httpClient.GetAsync(api);

                        if (response.IsSuccessStatusCode)
                        {
                            string resposta = await response.Content.ReadAsStringAsync();

                            ClienteDTO clienteRecuperado = JsonConvert.DeserializeObject<ClienteDTO>(resposta);

                            PreencherCamposComCliente(clienteRecuperado);
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
        private async void btnEditar_Click_1(object sender, EventArgs e)
        {
            int clienteId = Convert.ToInt32(IdClienteSelecionado);
            ClienteDTO clienteAtualizado = _mappearClienteDto.ObtenhaDadosAtualizadosDoCliente(IdClienteSelecionado, true, txtNome.Text, txtEmail.Text, txtSobrenome.Text, txtTelefone.Text, txtEndereco.Text, txtDataNascimento.Value);

            var api = apiUrl + "/" + clienteId;
            string json = JsonConvert.SerializeObject(clienteAtualizado);
            _crudGenerico.Editar(api, json);
            MessageBox.Show("Cliente editado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarClientes();
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _crudGenerico.Deletar(apiUrl, Convert.ToInt32(IdClienteSelecionado)).ToString();
            MessageBox.Show("Cliente excluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarClientes();
            LimparCampos();
        }
    }
}
