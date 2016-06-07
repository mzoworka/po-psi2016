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
        static string con = "server=localhost;database=projzesp;uid=root;password=";
        MySqlConnection connection = new MySqlConnection(con);
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader reader;
        static bool defined = false;
        ListViewItem lvi = new ListViewItem();
        bool ready = false;

        public Lista()
        {
            InitializeComponent();
            Zapytanie();
            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Zapytanie();
        }
        public void Zapytanie()
        {
            connection.Close();
            cmd.CommandText = "SELECT u.login FROM uzytkownik u right join znajomi z on z.id_znaj=u.id_user where z.id_user = @USRID";
            if (!defined)
            {
                cmd.Parameters.AddWithValue("@log", ProjGru2.ZmienneGlobalne.Login);
                cmd.Parameters.AddWithValue("@USRID", ProjGru2.ZmienneGlobalne.UserID);
                defined = true;
                ready = true;
            }

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            connection.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    ListViewItem lvi = UserList.FindItemWithText(reader.GetString(0));
                    if (lvi == null)
                    {
                        lvi = new ListViewItem(reader.GetString(0));
                        UserList.Items.Add(lvi);
                    }
                }
            }
            connection.Close();
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

        private void Ref()
        {
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

        private void UserList_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            e.Item.BackColor = Color.Lavender;
        }

        private void UserList_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo listViewHitTestInfo = UserList.HitTest(e.X, e.Y);

            // Index of the clicked ListView column
            int columnIndex = listViewHitTestInfo.Item.SubItems.IndexOf(listViewHitTestInfo.SubItem);
            ProjGru2.ZmienneGlobalne.Rozmowca = listViewHitTestInfo.Item.Text;
            Rozmowa rozmowa = new Rozmowa();
            rozmowa.Show();
        }
    }
}
