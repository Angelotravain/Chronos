using Newtonsoft.Json;
using System.Text;
using XSystem.Security.Cryptography;

namespace Chronos.Genericos
{
    public class MetodosComuns
    {
        public string RetornaSenhaCriptografada(string senha)
        {
            byte[] bytesSenha = Encoding.UTF8.GetBytes(senha);
            using (SHA256Managed sha256 = new SHA256Managed())
            {
                byte[] hash = sha256.ComputeHash(bytesSenha);
                return Convert.ToBase64String(hash).ToUpper();
            }
        }
        public void AbrirImagem(PictureBox pictureBox)
        {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Filter = "Arquivos de imagem (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|Todos os arquivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image imagem = Image.FromFile(openFileDialog.FileName);
                        pictureBox.Image = imagem;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível abrir o arquivo. Erro: " + ex.Message);
                    }
                }
            }
        }
        public byte[] ConverterImagemParaByte(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
            {
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "sem-foto.png");

                Image img = Image.FromFile(imagePath);
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, img.RawFormat);
                    return ms.ToArray();
                }
            }
            else
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }
        public void PreencherComboBoxAleatorio<T>(ComboBox comboBox, List<T> lista, string displayMember, string valueMember)
        {
            comboBox.DataSource = lista;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
        public async Task<List<T>> ListarDados<T>(string apiUrl)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string resposta = await response.Content.ReadAsStringAsync();
                    List<T> dadosRecuperados = JsonConvert.DeserializeObject<List<T>>(resposta);
                    return dadosRecuperados;
                }
            }

            return null; // Ou você pode lidar com erros de outra forma
        }

    }
}
