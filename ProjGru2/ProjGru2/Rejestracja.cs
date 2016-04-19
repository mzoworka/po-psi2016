using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjGru2
{
    public partial class Rejestracja : Form
    {
        
        public Rejestracja()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=Krystyna-HPAMD;" +
            "Initial Catalog=Baza;" +
            "User id=root;" +
            "Password=;";
            conn.Open();

        }
        private void bRej_Click(object sender, EventArgs e)  // zczytywanie zmiennych
        {
            string nick = txtOdbieranie.Text; ;
            char pass = Convert.ToChar(richTextBox1.Text);
            char pass2 = Convert.ToChar(richTextBox2.Text);
            char mail = Convert.ToChar(richTextBox3.Text);

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
