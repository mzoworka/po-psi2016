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
    public partial class Dodaj_kontakt : Form
    {


        //List<string> kontakt = new List<string>();


        class MyException : Exception
        {

        }

        public Dodaj_kontakt()
        {
            InitializeComponent();
        }

        private void Dodaj_bAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOdbieranie_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dodaj_bDodaj_Click(object sender, EventArgs e)
        {
 
                if (email.Text != null && email.Text != "" && nick.Text != null && nick.Text != "")
                {
                    ProjGru2.ZmienneGlobalne.Email = email.Text;
                    string con = "server=localhost;database=projzesp;uid=root;password=";
                    MySqlConnection connection = new MySqlConnection(con);
                    MySqlCommand cmd = new MySqlCommand();
                int znaj_id;
                

                    cmd.CommandText = "INSERT IGNORE INTO znajomi(id_user,id_znaj) VALUES(@USERID,(Select id_user from uzytkownik where login=@znajomy and email = @EMAIL))";
                    cmd.Parameters.AddWithValue("@znajomy", nick.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", email.Text);
                    cmd.Parameters.AddWithValue("@USERID", ProjGru2.ZmienneGlobalne.UserID);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    connection.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wypełnij pola");
                }
        }


    //przesuwanie
    private Point _mouseDown;
        private Point _formLocation;
        private bool _capture;

        // NOTE: we cannot use the WM_NCHITTEST / HTCAPTION trick because the table is in control, not the owning form...
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
