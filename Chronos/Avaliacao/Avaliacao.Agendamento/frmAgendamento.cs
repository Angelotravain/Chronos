using Chronos.Avaliacao.DTO.Agendamentos;
using Chronos.Avaliacao.DTO.Cadastros;
using Chronos.Genericos;
using Chronos.Genericos.Cadastros.Mapeamento;
using Chronos.Genericos.Crud;
using Newtonsoft.Json;

namespace Chronos.Avaliacao.Avaliacao.Agendamento
{
    public partial class frmAgendamento : Form
    {
        private string IdAgendamentoSelecionado { get; set; }
        private readonly MetodosComuns _comuns = new();
        private readonly MappearAgendamentoDto _mappearAgendamentoDto = new();
        private readonly AjustarComponentes _ajustarComponentes = new();
        private readonly CrudGenerico _crudGenerico = new();

        private string apiUrlCliente = URL.UrlCliente();
        private string apiUrlAgendamento = URL.UrlAgendamento();

        public frmAgendamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var hora = Convert.ToInt32(txtHora.Text.Replace(":", ""));
            if (hora < 800 || hora > 1800)
            {
                MessageBox.Show("Horário de agendamento não disponível, marque o agendamento entre as 08:00 e as 18:00!", "Mensagem");
            }
            else
            {
                string jsonSalvar = JsonConvert.SerializeObject(_mappearAgendamentoDto.ObtenhaDadosAtualizadosDoAgendamento("", false, (int)cbmCliente.SelectedValue, txtData.Value.Date, "Agendado", txtHora.Text, txtMensagem.Text));
                await _crudGenerico.Salvar(apiUrlAgendamento, jsonSalvar);
                ListarAgendamento();
                LimparCampos();
            }
        }

        private async void frmAgendamento_Load(object sender, EventArgs e)
        {
            txtHora.Text = "00:00";
            ListarAgendamento();
            _ajustarComponentes.ajustarGrid(gridAgendamento);
            _comuns.PreencherComboBoxAleatorio(cbmCliente, await _comuns.ListarDados<ClienteDTO>(apiUrlCliente), "Nome", "Id");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (IdAgendamentoSelecionado == string.Empty)
            {
                MessageBox.Show("Selecione um agendamento para editar!", "Atenção");
            }
            else
            {
                int agendamentoId = Convert.ToInt32(IdAgendamentoSelecionado);
                AgendamentoDTO agendamentoAtualizado = _mappearAgendamentoDto.ObtenhaDadosAtualizadosDoAgendamento(IdAgendamentoSelecionado, true, (int)cbmCliente.SelectedValue, txtData.Value.Date, "Reagendado", txtHora.Text, txtMensagem.Text);

                var api = apiUrlAgendamento + "/" + agendamentoId;
                string json = JsonConvert.SerializeObject(agendamentoAtualizado);
                _crudGenerico.Editar(api, json);
                MessageBox.Show("Agendamento editado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarAgendamento();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _crudGenerico.Deletar(apiUrlAgendamento, Convert.ToInt32(IdAgendamentoSelecionado)).ToString();
            MessageBox.Show("Agendamento excluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarAgendamento();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtHora.Text = "00:00";
            txtMensagem.Text = string.Empty;
        }

        private async void ListarAgendamento()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrlAgendamento);

                    if (response.IsSuccessStatusCode)
                    {
                        string resposta = await response.Content.ReadAsStringAsync();

                        List<AgendamentoDTO> agendamentoRecuperados = JsonConvert.DeserializeObject<List<AgendamentoDTO>>(resposta);
                        gridAgendamento.DataSource = agendamentoRecuperados.Where(e => e.DataHoraDoAgendamento == DateTime.Now.Date).OrderBy(e => e.Id).Select(e => new
                        {
                            Código = e.Id,
                            Data = e.DataHoraDoAgendamento.Date.ToString("dd/MM/yyyy"),
                            Hora = e.HoraAgendamento,
                            Status = e.StatusDoAgendamento
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

        private async void gridAgendamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridAgendamento.Rows[e.RowIndex];
                var recuperaCodigo = row.Cells["Código"].Value.ToString();
                IdAgendamentoSelecionado = recuperaCodigo;

                var api = apiUrlAgendamento + "/" + recuperaCodigo;

                try
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        HttpResponseMessage response = await httpClient.GetAsync(api);

                        if (response.IsSuccessStatusCode)
                        {
                            string resposta = await response.Content.ReadAsStringAsync();

                            var agendamentoRecuperado = JsonConvert.DeserializeObject<AgendamentoDTO>(resposta);

                            PreencherCamposComAgendamento(agendamentoRecuperado);
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

        private async void PreencherCamposComAgendamento(AgendamentoDTO? agendamentoRecuperado)
        {
            if (agendamentoRecuperado != null)
            {
                IdAgendamentoSelecionado = agendamentoRecuperado.Id.ToString();
                txtData.Value = agendamentoRecuperado.DataHoraDoAgendamento;
                txtHora.Text = agendamentoRecuperado.HoraAgendamento;
                var clientes = await _comuns.ListarDados<ClienteDTO>(apiUrlCliente);
                var clienteSelecionado = clientes.Where(cliente => cliente.Id == agendamentoRecuperado.IdCliente).First();
                cbmCliente.Text = clienteSelecionado.Nome;
                txtMensagem.Text = agendamentoRecuperado.MensagemAgendamento;
            }
        }
    }
}
