using Microsoft.EntityFrameworkCore;
using SistemaERP.Classes.Contextos;

namespace SistemaERP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());

            ContextoUsuario contexto = new ContextoUsuario();
            
            if (!TestarConexaoBanco())
            {
                MessageBox.Show("Conexão com o banco de dados com sucesso!.");
                l;




                Application.Run(new Login());
                
            }
            else
            {
                MessageBox.Show("Falha ao conectar com o banco de dados");
               
            }
                
        }

        private static bool TestarConexaoBanco()
        {
            try
            {
                using var contextoUsuario = new ContextoUsuario();
                return contextoUsuario.Database.CanConnect();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao conectar com o banco de dados");
                return false;
            }
        }
    }
}