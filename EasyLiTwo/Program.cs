using EasyLiTwo.Application.Frames;
using EasyLiTwo.Database.Infrastructure.Factory;
using System;

namespace EasyLiTwo
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Login(new Sqlite()));  //Define o banco de dados que será usado nesse ponto de entrada!
        }
    }
}
