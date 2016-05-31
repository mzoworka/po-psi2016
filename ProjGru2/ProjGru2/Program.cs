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
            Application.ApplicationExit += new EventHandler(ApplicationExitHandler);
            Kom kom = new Kom();
            Application.Run(kom);
            

    }
        private static void ApplicationExitHandler(Object sender, EventArgs e)
        {
           
            string con = "server=localhost;database=projzesp;uid=root;password=";
            MySqlConnection connection = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand();
            connection.Open();
            cmd.CommandText = "Delete FROM zalogowany WHERE id_user = @UID";
            cmd.Parameters.AddWithValue("@UID", ProjGru2.ZmienneGlobalne.UserID);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();

        }
    }
}
