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
        MySqlConnection Talkconnection1 = new MySqlConnection(conString);
        MySqlConnection Talkconnection2 = new MySqlConnection(conString);
        MySqlCommand polecenie1 = new MySqlCommand();
        MySqlCommand polecenie2 = new MySqlCommand();
        MySqlDataReader czytnik1;
        MySqlDataReader czytnik2;
        static bool podane = false;
        ListViewItem lvi = new ListViewItem();

        public Rozmowa()
        {
            InitializeComponent();
            //Wyswietl();
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

            Talkconnection1.Close();
            Talkconnection2.Close();
            polecenie1.Parameters.Clear();
            polecenie1.CommandText = "SELECT Wiadomosc From rozmowa where Autor = @Aut";
            czytnik1 = polecenie1.ExecuteReader();
            polecenie2.CommandText = "SELECT Wiadomosc From rozmowa where Autor = @Odb";
            czytnik2 = polecenie2.ExecuteReader();
            polecenie1.Parameters.AddWithValue("@Aut", ProjGru2.ZmienneGlobalne.Login);
            polecenie2.Parameters.AddWithValue("@Odb", ProjGru2.ZmienneGlobalne.Rozmowca);
            polecenie1.Connection = Talkconnection1;
            polecenie2.Connection = Talkconnection2;
            polecenie1.CommandType = CommandType.Text;
            polecenie2.CommandType = CommandType.Text;
            Talkconnection1.Open();
            Talkconnection2.Open();
           
         //   
            if (czytnik1.HasRows && czytnik2.HasRows)
           {

               while (czytnik1.Read() || czytnik2.Read())
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

        private void Rozmowa_bWyslij_Click(object sender, EventArgs e)
        {
            polecenie1.Parameters.Clear();
            Talkconnection1.Close();
            
            polecenie1.CommandText = "INSERT INTO rozmowa(Autor,Odbiorca,Wiadomosc) VALUES(@Aut,@Odb,@Wiad)";
            polecenie1.Parameters.AddWithValue("@Wiad", DoWyslania.Text);
            polecenie1.Parameters.AddWithValue("@Aut", ProjGru2.ZmienneGlobalne.Login);
            polecenie1.Parameters.AddWithValue("@Odb", ProjGru2.ZmienneGlobalne.Rozmowca);
            polecenie1.Connection = Talkconnection1;
            polecenie1.CommandType = CommandType.Text;
            Talkconnection1.Open();
            polecenie1.ExecuteNonQuery();
            Talkconnection1.Close();
            polecenie1.Parameters.Clear();
            podane = false;
            string text;
            text = DoWyslania.Text;
            DoWyslania.Text = "";
            textBox2.AppendText (ProjGru2.ZmienneGlobalne.Login);
            textBox2.AppendText(":    ");
            textBox2.AppendText(text);
        }
    }
}
