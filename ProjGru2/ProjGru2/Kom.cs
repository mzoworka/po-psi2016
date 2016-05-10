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
    public partial class Kom : Form
    {
        Rejestracja rej = new Rejestracja();
        Lista lista = new Lista();


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
                string login = Login.Text;
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

                lista.ShowDialog();
                Close();
            }
        }






        //Przesuwanie
        // NOTE: we cannot use the WM_NCHITTEST / HTCAPTION trick because the table is in control, not the owning form...


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
