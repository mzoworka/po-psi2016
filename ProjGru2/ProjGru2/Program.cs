using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Fabric;
using MySql.Web;
using MySql.Data.Entity;
using MySql.Data.Types;

namespace ProjGru2
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                Kom kom = new Kom();
                Rejestracja rej = new Rejestracja();
                Lista lista = new Lista();
                Rozmowa rozmowa = new Rozmowa();
                Application.Run(kom);
            Application.ApplicationExit += new EventHandler(ApplicationExitHandler);

    }
        private static void ApplicationExitHandler(Object sender, EventArgs e)
        {

            
        }
    }
}
