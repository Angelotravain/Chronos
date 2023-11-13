using System.Net.Http.Headers;

namespace Chronos.Genericos.Crud
{
    internal class CrudGenerico
    {
        public async Task<string> Salvar(string apiUrl, string json)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        return responseContent;
                    }
                    else
                        return "Erro na solicitação à API. Código de status: " + response.StatusCode;
                }
            }
            catch (Exception ex)
            {
                 return "Erro ao acessar a API: " + ex.Message;
            }
        }
        public async Task<string> Editar(string apiUrl, string json)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await httpClient.PutAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        return "Cliente editado com sucesso!";
                    }
                    else
                    {
                        return "Erro na solicitação à API. Código de status: " + response.StatusCode;
                    }
                }
            }
            catch (Exception ex)
            {
                return "Erro ao acessar a API: " + ex.Message;
            }
        }
        public async Task<string> Deletar(string apiUrl, int clienteId)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    string url = $"{apiUrl}/{clienteId}";

                    HttpResponseMessage response = await httpClient.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        return "Cliente excluído com sucesso!";
                    }
                    else
                    {
                        return "Erro na solicitação à API. Código de status: " + response.StatusCode;
                    }
                }
            }
            catch (Exception ex)
            {
                return "Erro ao acessar a API: " + ex.Message;
            }
        }
    }
}
