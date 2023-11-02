using Chronos.Avaliacao.DTO.Cadastros;
using FastReport.Export.PdfSimple;
using Newtonsoft.Json;

namespace Chronos.Avaliacao.Avaliacao.Relatorio
{
    public class relClientes
    {
        private async Task<List<ClienteDTO>> ListarClientesRelatorioDoServidor()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(URL.UrlCliente());

                if (response.IsSuccessStatusCode)
                {
                    string resposta = await response.Content.ReadAsStringAsync();
                    List<ClienteDTO> clientesRecuperados = JsonConvert.DeserializeObject<List<ClienteDTO>>(resposta);
                    return clientesRecuperados;
                }
            }
            return new List<ClienteDTO>();
        }

        public async Task CriarEstruturaRelatorioClientes()
        {
            string pastaRelatorios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Relatorios");
            Directory.CreateDirectory(pastaRelatorios);
            string caminhoReport = Path.Combine(pastaRelatorios, "relClientes.frx");
            var reportFile = caminhoReport;
            var freport = new FastReport.Report();
            var ListaClientes = await ListarClientesRelatorioDoServidor(); // Aguarda a conclusão da tarefa

            freport.Dictionary.RegisterBusinessObject((System.Collections.IEnumerable)ListaClientes, "ListaClientes", 10, true);
            freport.Report.Save(reportFile);

            MessageBox.Show($"Relatório gerado: {caminhoReport}");
        }

        public async Task CriarRelatorioClientes()
        {
            try
            {
                string pastaRelatorios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Relatorios");
                string caminhoReport = Path.Combine(pastaRelatorios, "relClientes.frx");
                var reportFile = caminhoReport;
                var freport = new FastReport.Report();
                var ListaClientes = await ListarClientesRelatorioDoServidor();

                freport.Report.Load(reportFile);
                freport.Dictionary.RegisterBusinessObject((System.Collections.IEnumerable)ListaClientes, "ListaClientes", 10, true);
                freport.Prepare();

                var pdfExport = new PDFSimpleExport();

                using MemoryStream ms = new MemoryStream();
                pdfExport.Export(freport, ms);
                ms.Flush();

                string caminhoRelatorioPDF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"RelatorioClientes.pdf");
                using (FileStream fs = new FileStream(caminhoRelatorioPDF, FileMode.Create))
                {
                    ms.WriteTo(fs);
                }
                Visualizar.Abrir(caminhoRelatorioPDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao imprimir: " + ex.Message);
            }
        }
    }
}
