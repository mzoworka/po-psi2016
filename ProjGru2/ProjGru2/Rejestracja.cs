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
using MySql.Fabric;
using MySql.Web;

namespace ProjGru2
{
    public partial class Rejestracja : Form
    {
        
        public Rejestracja()
        {
            InitializeComponent();

        }
        string connectionstring = "Server=217.173.198.143;Database=s86849_gra;Uid=komunikator;Pwd=Start123";
        private void bRej_Click(object sender, EventArgs e)  // zczytywanie zmiennych
        {

            bool ready = true;

            try
            {
                string login = txtOdbieranie.Text;
                if (login != null)
                {
                    lLoginError.Visible = false;
                }
                else
                {
                    ready = false;
                }

                string password = Password.Text;

                if (password != null)
                {
                    lPasswordError.Visible = false;
                }
                else
                {
                    ready = false;
                }

                string passwordCheck = PasswordCheck.Text;

                if (passwordCheck != null && password == passwordCheck)
                {
                    lPasswordCheckError.Visible = false;
                }
                else
                {
                    ready = false;
                }

                string email = Email.Text;

                if (email != null)
                {
                    lEmailError.Visible = false;
                }
                else
                {
                    ready = false;
                }

            }
            catch
            {
                if (ready == false)
                {
                    MessageBox.Show("Popraw dane");
                }
            }
            finally
            {
                MySqlConnection connection = new MySqlConnection(connectionstring);
                MySqlCommand cmd;
                connection.Open();
                Random r = new Random();
                try
                {
                    //na dole jest dodawanie użytkownika do bazy z kinekta, trzeba pozmieniać.
                   // cmd = connection.CreateCommand();
                   // cmd.CommandText = "INSERT INTO uzytkownik(id_user,login,zalogowany) VALUES(@id,@log,@zal)";
                   // cmd.Parameters.AddWithValue("@id", (r.Next(0, 200)));
                   // cmd.Parameters.AddWithValue("@log", log);
                    //cmd.Parameters.AddWithValue("@zal", true);
                    //cmd.ExecuteNonQuery();

                }
                catch (Exception)
                { throw; }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)

                    {
                        connection.Close();

                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        // Window Drag
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
                //asdasdasdasdasd
            }
        }
    }
}
