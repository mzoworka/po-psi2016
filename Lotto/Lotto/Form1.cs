using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Lotto : Form
    {
        public Lotto()
        {
            InitializeComponent();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public static int c1,c2; // zmienne odpowiadające za checkboxy
       
        public static int para; //licznik trafień
        public static int i,k;
        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        private void button3_Click(object sender, EventArgs e) //przycisk sprawdź
        {
            if (c1 == 1)
            { log.Text = "";
                if (c2 == 1)
                { log.Text = "";
                    int[] los = new int[7];
                    int[] wpis = new int[7];
                    for (i = 1; i <= 7; i++)
                    {
                        los[1] = Int32.Parse(li1.Text);
                        los[2] = Int32.Parse(li2.Text);
                        los[3] = Int32.Parse(li3.Text);
                        los[4] = Int32.Parse(li4.Text);
                        los[5] = Int32.Parse(li5.Text);
                        los[6] = Int32.Parse(li6.Text);
                    }
                    for (i = 1; i <= 7; i++)
                    {
                        wpis[1] = Int32.Parse(wp1.Text);
                        wpis[2] = Int32.Parse(wp2.Text);
                        wpis[3] = Int32.Parse(wp3.Text);
                        wpis[1] = Int32.Parse(wp4.Text);
                        wpis[2] = Int32.Parse(wp5.Text);
                        wpis[3] = Int32.Parse(wp6.Text);
                    }
                    para = 0;
                    for (i = 1; i <= 6; i++)
                    {
                        if (los[i] == wpis[k])
                        { para++; }
                        for (k = 1; k <= 6; k++)
                        {
                            if(los[i]==wpis[k])
                            { para++; }

                                                
                        }

                    }
                    wynik.Text = Convert.ToString(para);

                }
                else
                { log.Text = "Sprawdź czy zaznaczyłeś poprawność liczb!"; } }
            else
            { log.Text = "Sprawdź czy zaznaczyłeś poprawność liczb!"; }
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { c1 = 1;
                
              
            }
            else
            { c1 = 0; }
        }

      
         
        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            { c2 = 1; }
            else
            { c2 = 0; }
        }

        
    }
}
