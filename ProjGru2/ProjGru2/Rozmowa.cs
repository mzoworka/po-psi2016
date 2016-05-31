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
    public partial class Rozmowa : Form
    {
        static string conString = "server=localhost;database=projzesp;uid=root;password=";
        MySqlConnection Talkconnection = new MySqlConnection(conString);
        MySqlCommand polecenie = new MySqlCommand();
        MySqlDataReader czytnik;
       // static bool defined = false;
        ListViewItem lvi = new ListViewItem();

        public Rozmowa()
        {
            InitializeComponent();
            Wyswietl();
            Timer timer = new Timer();
            timer.Interval = (5 * 1000); // 5 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Wyswietl();
        }

        private void Wyswietl()
        {
            polecenie.CommandText = "SELECT A.Autor, A.Wiadomosc, B.Autor, B.Wiadomosc FROM rozmowa WHERE A.Autor = @Log and A.Odbiorca=@odb and B.Autor = @Log and B.Odbiorca=@odb GROUP BY DateStamp";
            polecenie.Connection = Talkconnection;
            Talkconnection.Open();
            czytnik = polecenie.ExecuteReader();
            if (czytnik.HasRows)
            {
                while (czytnik.Read())
                {

                }
            }
        }

        private void Rozmowa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

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

        private void Rozmowa_bZdjecie_Click(object sender, EventArgs e)
        {
            OpenFileDialog okienko = new OpenFileDialog();
            okienko.Filter = "Obrazy (.jpg)|*.jpg|(.bmp)|*.bmp|(.jpeg)|*.jpeg";

            if (okienko.ShowDialog() == DialogResult.OK)
            {

                //path = okienko.FileName;
            }
        }
    }
}
