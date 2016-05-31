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
    public partial class Lista : Form
    {
        static Dodaj_kontakt dodaj_kontakt = new Dodaj_kontakt();
        

        public Lista()
        {
            InitializeComponent();
        }



        protected virtual void OnLoad()
        {
            string con = "server=localhost;database=projzesp;uid=root;password=";
            MySqlConnection connection = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;
            connection.Open();
            cmd.CommandText = "Select * FROM znajomi WHERE @log";
            cmd.Parameters.AddWithValue("@log", ProjGru2.ZmienneGlobalne.Login);

        }

        private void Dodaj_kontakt_Click(object sender, EventArgs e)
        {
            dodaj_kontakt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
        
        // przesuwanie
        private void txtOdbieranie_TextChanged(object sender, EventArgs e)
        {

        }
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
