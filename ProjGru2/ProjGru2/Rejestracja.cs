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
using MySql.Data.Entity;
using MySql.Data.Types;


namespace ProjGru2
{
    public partial class Rejestracja : Form
    {
        
        public Rejestracja()
        {
            InitializeComponent();
        }

        class MyException : Exception
        {

    

        }


        private void bRej_Click(object sender, EventArgs e)  // zczytywanie zmiennych
        {
            bool ready = false;

            try
            {
                string login = null;
                string password = null;
                string passwordCheck = null;
                string email = null;

                login = txtOdbieranie.Text;
                password = Password.Text;
                passwordCheck = PasswordCheck.Text;
                email = Email.Text;

                if (login == null || password == null || passwordCheck == null || email == null)
                {
                    throw new MyException();
                }

                else
                {

                    if (login != "")
                    {
                        lLoginError.Visible = false;

                        if (password != "")
                        {
                            lPasswordError.Visible = false;

                            if (passwordCheck != "" && password == passwordCheck)
                            {

                                lPasswordCheckError.Visible = false;

                                if (email != "")
                                {
                                    lEmailError.Visible = false;
                                    ready = true;
                                }
                            }
                        }
                    }
                }
                if (ready == false)
                {
                    throw new MyException();
                }
            }

            catch (MyException)
            {
                richTextBox4.Text = "Rejestracja nieudana.";
            }

            if (ready == true)
                {
                    string con = "server=localhost;database=projzesp;uid=root;password=";
                    MySqlConnection connection = new MySqlConnection(con);
                    MySqlCommand cmd;
                    connection.Open();
                  
                    try
                    {
                        string log = txtOdbieranie.Text;
                        string has = PasswordCheck.Text;
                        string em = Email.Text;
                        cmd = connection.CreateCommand();
                        cmd.CommandText = "INSERT INTO uzytkownik(login,pass,email) VALUES(@log,@pass,@email)";
                      
                        cmd.Parameters.AddWithValue("@log", log);
                        cmd.Parameters.AddWithValue("@pass", has);
                        cmd.Parameters.AddWithValue("@email", em);
                        cmd.ExecuteNonQuery();
                        richTextBox4.Text = "Zostałeś zarejestrowany. Wróć do ekranu logowania.";

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
                Close();
                }
            }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
