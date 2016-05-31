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
    public partial class Kom : Form
    {
        
        //public string login;

        public Kom()
        {
            InitializeComponent();
        }

        class MyException : Exception
        {


        }
        
        private void bLogin_Click(object sender, EventArgs e)
        {

        }

        private void bRej_Click(object sender, EventArgs e)
        {
            Rejestracja rej = new Rejestracja();
            rej.ShowDialog();
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

        private void bLogin_Click_1(object sender, EventArgs e)
        {
            bool ready = true;
            try
            {

                string password = Password.Text;
                ProjGru2.ZmienneGlobalne.Password = password;
                string login = Login.Text;
                ProjGru2.ZmienneGlobalne.Login = login;
                if ((login == "" || login == null) && (password == "" || password == null))
                {
                    ready = false;
                    throw new MyException();

                }

            }
            catch (MyException)
            {
                txtLog.Text = "Nie znaleziono użytkownika";
            }

            if (ready == true)
            {
                string con = "server=localhost;database=projzesp;uid=root;password=";
                MySqlConnection connection = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader reader;
                cmd.CommandText = "Select id_user, login, pass FROM uzytkownik WHERE login = @log and pass = @pwd";
                cmd.Parameters.AddWithValue("@log", ProjGru2.ZmienneGlobalne.Login);
                cmd.Parameters.AddWithValue("@pwd", ProjGru2.ZmienneGlobalne.Password);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                connection.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProjGru2.ZmienneGlobalne.UserID = reader.GetInt32(0);
                        MessageBox.Show(ProjGru2.ZmienneGlobalne.UserID.ToString() + ProjGru2.ZmienneGlobalne.Login);
                        ProjGru2.ZmienneGlobalne.Login = reader.GetString(1);
                        ProjGru2.ZmienneGlobalne.Password = reader.GetString(2);
                    }
                    connection.Close();
                    connection.Open();
                    cmd.CommandText = "INSERT INTO zalogowany(id_user, login, status_zal) VALUES(@UID,@log,1)";
                    cmd.Parameters.AddWithValue("@UID", ProjGru2.ZmienneGlobalne.UserID);
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    Lista lista = new Lista();
                    lista.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowe dane");
                }
                connection.Close();
            }
        }
        //Przesuwanie
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

       
    }
}
