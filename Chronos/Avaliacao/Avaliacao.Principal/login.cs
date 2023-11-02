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

namespace Chronos.Avaliacao.Avaliacao.Principal
{
    public partial class login : Form
    {
        private readonly MetodosComuns _metodosComuns = new();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarUsuarios(txtLogin.Text, txtSenha.Text);
        }
        private async void ListarUsuarios(string login, string senha)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(URL.UrlUsuario());

                    if (response.IsSuccessStatusCode)
                    {
                        string resposta = await response.Content.ReadAsStringAsync();

                        List<UsuarioDTO> usuarioRecuperados = JsonConvert.DeserializeObject<List<UsuarioDTO>>(resposta);
                        var senhaCripto = _metodosComuns.RetornaSenhaCriptografada(senha);
                        var logar = false;
                        foreach (var usuario in usuarioRecuperados)
                        {
                            if (senhaCripto == usuario.Senha && login == usuario.NomeUsuario)
                                logar = true;
                        }
                        if (logar)
                            this.Dispose();
                        else
                        {
                            MessageBox.Show("Login ou senha inválidos, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtLogin.Text = string.Empty;
                            txtSenha.Text = string.Empty;
                            txtLogin.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar a API: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Deseja realmente fechar o sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
