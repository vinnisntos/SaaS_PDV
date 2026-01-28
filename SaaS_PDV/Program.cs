namespace SaaS_PDV
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // parei aqui, static void main
            SaaS_PDV.Data.DbInitializer.Seed();

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmSplash());
        }
    }
}