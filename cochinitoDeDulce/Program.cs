using cochinitoDeDulce.Views;
//
using cochinitoDeDulce.Presenters;
using cochinitoDeDulce._DataBase;
using cochinitoDeDulce.Models;
using System.Configuration;

namespace cochinitoDeDulce
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
            //
            string SqlCadenaConexion = ConfigurationManager.ConnectionStrings["SqliteCadenaConexion"].ConnectionString;
            IPrincipalView vista = new PrincipalView();
            new PrincipalPresenter(vista, SqlCadenaConexion);
            //
            Application.Run((Form)vista);
        }
    }
}