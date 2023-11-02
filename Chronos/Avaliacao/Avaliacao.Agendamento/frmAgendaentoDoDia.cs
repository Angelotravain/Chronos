using Chronos.Avaliacao.Avaliacao.Processos;
using Chronos.Avaliacao.Avaliacao.Relatorio;
using Chronos.Avaliacao.DTO.Agendamentos;
using Chronos.Genericos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Chronos.Avaliacao.Avaliacao.Agendamento
{
    public partial class frmAgendaentoDoDia : Form
    {
        private readonly AjustarComponentes _ajustarComponente = new();
        private readonly relAgendamentoDoDia _relAgendamento = new();
        private List<AgendamentoDTO> AgendamentoRecuperados { get; set; }
        public frmAgendaentoDoDia()
        {
            InitializeComponent();
        }

        private void frmAgendaentoDoDia_Load(object sender, EventArgs e)
        {
            ListarAgendamento();
            _ajustarComponente.ajustarGrid(gridAgendamento);
        }

        private async void gridAgendamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridAgendamento.Rows[e.RowIndex];
            var recuperaCodigo = row.Cells["Código"].Value.ToString();
            var api = URL.UrlAgendamento() + "/" + recuperaCodigo;

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(api);

                    if (response.IsSuccessStatusCode)
                    {
                        string resposta = await response.Content.ReadAsStringAsync();

                        var agendamentoRecuperado = JsonConvert.DeserializeObject<AgendamentoDTO>(resposta);

                        frmAvaliacaoFisica frm = new(agendamentoRecuperado, agendamentoRecuperado.IdCliente);
                        frm.ShowDialog();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            _relAgendamento.CriarRelatorioAgendamento(await ListarAgendamento());
        }
        private async Task<List<AgendamentoDTO>> ListarAgendamento()
        {
            try
            {
                List<AgendamentoDTO> agendamentosSelecionados = new();
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(URL.UrlAgendamento());

                    if (response.IsSuccessStatusCode)
                    {
                        string resposta = await response.Content.ReadAsStringAsync();

                        AgendamentoRecuperados = JsonConvert.DeserializeObject<List<AgendamentoDTO>>(resposta);
                        foreach (var agendamento in AgendamentoRecuperados)
                        {
                            if (agendamento.StatusDoAgendamento != "Realizado" && agendamento.HoraAgendamento != null)
                            {
                                agendamentosSelecionados.Add(agendamento);
                            }
                        }
                        gridAgendamento.DataSource = agendamentosSelecionados.Select(e => new
                        {
                            Código = e.Id,
                            Data = e.DataHoraDoAgendamento.Date.ToString("dd/MM/yyyy"),
                            Hora = e.HoraAgendamento,
                            Status = e.StatusDoAgendamento
                        }).ToList();
                        var quantidade = 0;
                        foreach (var item in AgendamentoRecuperados.Where(e => e.DataHoraDoAgendamento == DateTime.Now.Date || (e.StatusDoAgendamento.Equals("Agendado") || e.StatusDoAgendamento.Equals("Reagendado")) && e.HoraAgendamento != null))
                        {
                            quantidade++;
                        }
                        txtQuantidadeAgendamentos.Text = $"Quantidade de agendamentos do dia: {quantidade}";
                    }
                    else
                    {
                        MessageBox.Show("Erro na solicitação à API. Código de status: " + response.StatusCode, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return agendamentosSelecionados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar a API: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<AgendamentoDTO>();
        }
    }
}
