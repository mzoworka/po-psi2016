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
    public partial class Lista : Form
    {
        Dodaj_kontakt dodaj_kontakt = new Dodaj_kontakt();

        public Lista()
        {
            InitializeComponent();
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
    }
}
