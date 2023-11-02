using Chronos.Avaliacao.Avaliacao.Relatorio;
using Chronos.Avaliacao.DTO.Cadastros;
using Chronos.Genericos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos.Avaliacao.Avaliacao.Cadastros
{
    public partial class frmRelatorioCliente : Form
    {
        private readonly AjustarComponentes _ajustarComponentes = new();
        private readonly relClientes _relClientes = new();
        public frmRelatorioCliente()
        {
            InitializeComponent();
        }

        private void frmRelatorioCliente_Load(object sender, EventArgs e)
        {
            _ajustarComponentes.ajustarGrid(gridRelatorioCliente);
            ListarClientes();
        }
        private async void ListarClientes()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(URL.UrlCliente());

                    if (response.IsSuccessStatusCode)
                    {
                        string resposta = await response.Content.ReadAsStringAsync();

                        List<ClienteDTO> clientesRecuperados = JsonConvert.DeserializeObject<List<ClienteDTO>>(resposta);
                        gridRelatorioCliente.DataSource = clientesRecuperados.OrderBy(c => c.Id).Select(c => new
                        {
                            Código = c.Id,
                            Cliente = c.Nome + " " + c.Sobrenome,
                            Nascimento = Convert.ToDateTime(c.DataNascimento).ToString("dd/MM/yyyy")
                        }).ToList();
                        txtQuantidadeClientes.Text = $"Quantidade de clientes cadastrados: {clientesRecuperados.Count}";
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
            await _relClientes.CriarRelatorioClientes();
        }
    }
}
