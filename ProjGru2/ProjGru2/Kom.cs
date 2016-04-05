using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjGru2
{
    public partial class frmLogowanie : Form
    {
        Rejestracja rej = new Rejestracja();

        public frmLogowanie()
        {
            InitializeComponent();
            if (!rej.Visible) { this.Show(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void bRej_Click(object sender, EventArgs e)
        {
            rej.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}
