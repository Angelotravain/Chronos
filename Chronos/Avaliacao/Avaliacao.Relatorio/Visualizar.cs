using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Avaliacao.Avaliacao.Relatorio
{
    public static class Visualizar
    {
        public static void Abrir(string caminho)
        {
            string pdfPath = caminho;
            if (File.Exists(pdfPath))
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = pdfPath,
                        UseShellExecute = true
                    };
                    Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao abrir o arquivo PDF: {ex.Message}");
                }
            }
            else
                MessageBox.Show("O arquivo PDF não existe.");
        }
    }
}
