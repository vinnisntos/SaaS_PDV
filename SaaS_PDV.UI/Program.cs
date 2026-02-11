using System;
using System.Windows.Forms;
using SaaS_PDV.Core.Data;
using SaaS_PDV.UI.Forms;
using SaaS_PDV.Data; // Added to access AppDbContext

namespace SaaS_PDV.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Inicializa as configurações visuais do Windows 11
            ApplicationConfiguration.Initialize();

            // 1. Tenta rodar o Seed do Banco de Dados
            try
            {
                // DbInitializer.Seed(); <-- não existe. Criar um contexto e chamar Initialize
                using (var context = new AppDbContext())
                {
                    DbInitializer.Initialize(context);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no Banco: {ex.Message}\n\nVerifique se o banco existe no SQL Server.",
                                "Erro de Inicialização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Fluxo das Telas (Splash -> Login)
            using (FrmSplash splash = new FrmSplash())
            {
                if (splash.ShowDialog() == DialogResult.OK)
                {
                    // Se o Splash deu "OK", o loop principal do sistema começa aqui
                    Application.Run(new FrmLogin());
                }
                else
                {
                    // Caso o Splash feche sem o DialogResult.OK
                    MessageBox.Show("O sistema não pôde ser iniciado porque o carregamento falhou.", "Aviso");
                }
            }
        }
    }
}