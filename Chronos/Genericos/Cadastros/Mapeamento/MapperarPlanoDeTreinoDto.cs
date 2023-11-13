using Chronos.Avaliacao.DTO.PosAvaliacao;
using Newtonsoft.Json;

namespace Chronos.Genericos.Cadastros.Mapeamento
{
    public class MapperarPlanoDeTreinoDto
    {
        public async Task<int> BuscaIdDoTreinoAtual(int idCliente)
        {
            var retorno = 1;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(URL.UrlPlanoTreino(idCliente));

                    if (response.IsSuccessStatusCode)
                    {
                        string resposta = await response.Content.ReadAsStringAsync();
                        List<PlanoTreinoDTO> PlanosRecuperados = JsonConvert.DeserializeObject<List<PlanoTreinoDTO>>(resposta);
                        if (PlanosRecuperados != null && PlanosRecuperados.Count > 0)
                        {
                            retorno = PlanosRecuperados.OrderByDescending(p => p.Id).Select(p => p.IdDoTreino).First();
                            retorno += 1;
                        }
                        else
                            MessageBox.Show("Erro na solicitação à API. Código de status: " + response.StatusCode, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("Erro ao acessar a API: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retorno;
        }
    }
}
