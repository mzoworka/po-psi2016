using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjGru2
{
    public partial class Kom : Form
    {
       



        public Kom()
        {
            InitializeComponent();
        }

        class MyException : Exception
        {



        }


        private void bLogin_Click(object sender, EventArgs e)
        {


            try
            {
                string password = Password.Text;
                string login = Login.Text;
                if (login != null && password != null)
                {

                }


            }
            catch (MyException)
            {
                MessageBox.Show("Błąd", "Nie znaleziono użytkownika", MessageBoxButtons.OK);
            }

            finally
            {

            }
        }

        private void bRej_Click(object sender, EventArgs e)
        {
            Rejestracja rej = new Rejestracja();
            rej.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }



        private void optBtn_Click(object sender, EventArgs e)
        {

            this.Visible = false;
        }




        //Przesuwanie
        // NOTE: we cannot use the WM_NCHITTEST / HTCAPTION trick because the table is in control, not the owning form...


        private Point _mouseDown;
        private Point _formLocation;
        private bool _capture;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            _capture = true;
            _mouseDown = e.Location;
            _formLocation = ((Form)TopLevelControl).Location;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _capture = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_capture)
            {
                int dx = e.Location.X - _mouseDown.X;
                int dy = e.Location.Y - _mouseDown.Y;
                Point newLocation = new Point(_formLocation.X + dx, _formLocation.Y + dy);
                ((Form)TopLevelControl).Location = newLocation;
                _formLocation = newLocation;
            }
        }
        int result;
        private void bLogin_Click_1(object sender, EventArgs e)
        {
            /*  string log = Login.Text;
              string has = Password.Text;

              string con = "server=localhost;database=projzesp;uid=root;password=";
              MySqlConnection connection = new MySqlConnection(con);
              MySqlCommand cmd;

              connection.Open();

              try
              {

                  cmd = connection.CreateCommand();
                  cmd.CommandText = "SELECT login,pass FROM uzytkownik WHERE login='log' AND pass='has'";
                  cmd.CommandText = "INSERT INTO zalogowany(login,status_zal) VALUES(@log,@stat)";
                  cmd.Parameters.AddWithValue("@log", log);
                  cmd.Parameters.AddWithValue("@stat", 1);
                  cmd.ExecuteNonQuery();


              }

              finally
              {
                  if (connection.State == System.Data.ConnectionState.Open)

                  {
                      connection.Close();

                  }

              }
                     }*/
        }


    }
}
