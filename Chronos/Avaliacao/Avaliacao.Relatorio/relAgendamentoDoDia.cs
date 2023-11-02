using Chronos.Avaliacao.DTO.Agendamentos;
using FastReport.Export.PdfSimple;

namespace Chronos.Avaliacao.Avaliacao.Relatorio
{
    public class relAgendamentoDoDia
    {
        public async Task CriarEstruturaRelatorioAgendamentos(List<AgendamentoDTO> listaEntrada)
        {
            string pastaRelatorios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Relatorios");
            Directory.CreateDirectory(pastaRelatorios);
            string caminhoReport = Path.Combine(pastaRelatorios, "agendamentos.frx");
            var reportFile = caminhoReport;
            var freport = new FastReport.Report();

            freport.Dictionary.RegisterBusinessObject(listaEntrada, "ListaAgendamento", 10, true);
            freport.Report.Save(reportFile);

            MessageBox.Show($"Relatório gerado: {caminhoReport}");
        }

        public async Task CriarRelatorioAgendamento(List<AgendamentoDTO> listaEntrada)
        {
            try
            {
                string pastaRelatorios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Relatorios");
                string caminhoReport = Path.Combine(pastaRelatorios, "agendamentos.frx");
                var reportFile = caminhoReport;
                var freport = new FastReport.Report();

                freport.Report.Load(reportFile);
                freport.Dictionary.RegisterBusinessObject(listaEntrada, "ListaAgendamentos", 10, true);
                freport.Prepare();

                var pdfExport = new PDFSimpleExport();

                using MemoryStream ms = new MemoryStream();
                pdfExport.Export(freport, ms);
                ms.Flush();

                string caminhoRelatorioPDF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Agendamento.pdf");
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
