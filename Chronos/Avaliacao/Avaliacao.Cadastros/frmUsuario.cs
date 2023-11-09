using Chronos.Avaliacao.DTO.Cadastros;
using Chronos.Genericos;
using Chronos.Genericos.Cadastros.Mapeamento;
using Chronos.Genericos.Crud;
using Newtonsoft.Json;

namespace Chronos.Avaliacao.Avaliacao.Cadastros
{
    public partial class frmUsuario : Form
    {
        private string IdUsuarioSelecionado { get; set; }
        private string SenhaUsuarioSelecionado { get; set; }

        private readonly AjustarComponentes _ajustarComponentes = new();
        private readonly MappearUsuarioDto _mappearUsuarioDto = new();
        private readonly CrudGenerico _crudGenerico = new();
        private string apiUrl = URL.UrlUsuario();
        public frmUsuario()
        {
            InitializeComponent();
            _ajustarComponentes.ajustarGrid(gridUsuario);
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
            AtualizarComandos("Novo");
        }
        private void AtualizarComandos(string comando)
        {
            switch (comando)
            {
                case "Editar":
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;
                case "Novo":
                    btnSalvar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    break;
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            string jsonSalvar = JsonConvert.SerializeObject(_mappearUsuarioDto.ObtenhaDadosAtualizadosDoUsuario("", "", false, txtUsuario.Text, txtSenha.Text, cbmNivelAcesso.SelectedItem.ToString()));
            await _crudGenerico.Salvar(apiUrl, jsonSalvar);
            ListarUsuarios();
            LimparCampos();
            AtualizarComandos("Novo");
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            int usuarioId = Convert.ToInt32(IdUsuarioSelecionado);
            UsuarioDTO usuarioAtualizado = _mappearUsuarioDto.ObtenhaDadosAtualizadosDoUsuario(IdUsuarioSelecionado, SenhaUsuarioSelecionado, true, txtUsuario.Text, txtSenha.Text, cbmNivelAcesso.SelectedItem.ToString());

            var api = apiUrl + "/" + usuarioId;
            string json = JsonConvert.SerializeObject(usuarioAtualizado);
            _crudGenerico.Editar(api, json);
            MessageBox.Show("Usuario editado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarUsuarios();
            LimparCampos();
            AtualizarComandos("Novo");
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            _crudGenerico.Deletar(apiUrl, Convert.ToInt32(IdUsuarioSelecionado)).ToString();
            MessageBox.Show("Usuário excluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarUsuarios();
            LimparCampos();
            AtualizarComandos("Novo");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private async void gridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridUsuario.Rows[e.RowIndex];
                var recuperaCodigo = row.Cells["Código"].Value.ToString();
                IdUsuarioSelecionado = recuperaCodigo;

                var api = apiUrl + "/" + recuperaCodigo;

                try
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        HttpResponseMessage response = await httpClient.GetAsync(api);

                        if (response.IsSuccessStatusCode)
                        {
                            string resposta = await response.Content.ReadAsStringAsync();

                            UsuarioDTO usuarioRecuperado = JsonConvert.DeserializeObject<UsuarioDTO>(resposta);

                            PreencherCamposComUsuario(usuarioRecuperado);
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
            AtualizarComandos("Editar");
        }

        private void PreencherCamposComUsuario(UsuarioDTO? usuarioRecuperado)
        {
            txtSenha.Text = usuarioRecuperado.Senha;
            txtUsuario.Text = usuarioRecuperado.NomeUsuario;
            cbmNivelAcesso.Text = usuarioRecuperado.NivelAcesso;
            SenhaUsuarioSelecionado = usuarioRecuperado.Senha;
            IdUsuarioSelecionado = usuarioRecuperado.Id.ToString();
        }

        private void LimparCampos()
        {
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }
        private async void ListarUsuarios()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string resposta = await response.Content.ReadAsStringAsync();

                        List<UsuarioDTO> usuarioRecuperados = JsonConvert.DeserializeObject<List<UsuarioDTO>>(resposta);
                        gridUsuario.DataSource = usuarioRecuperados.OrderBy(u => u.Id).Select(u => new
                        {
                            Código = u.Id,
                            Usuario = u.NomeUsuario
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

        private void cbmNivelAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
