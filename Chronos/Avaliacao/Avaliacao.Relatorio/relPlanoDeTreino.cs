using Chronos.Avaliacao.DTO.Agendamentos;
using Chronos.Avaliacao.DTO.PosAvaliacao;
using FastReport.Export.PdfSimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Avaliacao.Avaliacao.Relatorio
{
    public class relPlanoDeTreino
    {
        public async Task CriarEstruturaRelatorioPlanodeTreino(List<PlanoTreinoDTO> listaEntrada)
        {
            string pastaRelatorios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Relatorios");
            Directory.CreateDirectory(pastaRelatorios);
            string caminhoReport = Path.Combine(pastaRelatorios, "planoTreino.frx");
            var reportFile = caminhoReport;
            var freport = new FastReport.Report();

            freport.Dictionary.RegisterBusinessObject(listaEntrada, "ListaPlanoTreino", 10, true);
            freport.Report.Save(reportFile);

            MessageBox.Show($"Relatório gerado: {caminhoReport}");
        }

        public async Task CriarRelatorioPlanoDeTreino(List<PlanoTreinoDTO> listaEntrada)
        {
            try
            {
                string pastaRelatorios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Relatorios");
                string caminhoReport = Path.Combine(pastaRelatorios, "planoTreino.frx");
                var reportFile = caminhoReport;
                var freport = new FastReport.Report();

                freport.Report.Load(reportFile);
                freport.Dictionary.RegisterBusinessObject(listaEntrada, "ListaPlanoTreino", 10, true);
                freport.Prepare();

                var pdfExport = new PDFSimpleExport();

                using MemoryStream ms = new MemoryStream();
                pdfExport.Export(freport, ms);
                ms.Flush();

                string caminhoRelatorioPDF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"planoTreino.pdf");
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
