using Chronos.Avaliacao.Avaliacao.Principal;

namespace Chronos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Principal());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Estouro de mensagem no ambiente geral: " + ex.Message);
            }
        }
    }
}