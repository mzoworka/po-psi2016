using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;
using System.Globalization;

namespace TowerDefend
{
    /// <summary>
    /// Interaction logic for nick.xaml
    /// </summary>
    public partial class nick : Window
    {
        private KinectSensorChooser sensorChooser;
        private KinectSensor _sensor;
        public nick()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e) // odnieść się do Window_loaded w Main Window
        {

            this.sensorChooser = new KinectSensorChooser();
            this.sensorChooserUi.KinectSensorChooser = this.sensorChooser;
            this.sensorChooser.Start();

            if (KinectSensor.KinectSensors.Count > 0)
            {
                _sensor = KinectSensor.KinectSensors[0];

                if (_sensor.Status == KinectStatus.Connected)
                {
                    try
                    {
                        _sensor.ColorStream.Enable();
                        _sensor.DepthStream.Enable();
                        _sensor.SkeletonStream.Enable();
                        _sensor.AllFramesReady += new EventHandler<AllFramesReadyEventArgs>(_sensor_AllFramesReady);
                        _sensor.Start();
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("Dupa");
                        this.Close();
                    }
                }
            }
        }

        private void _sensor_AllFramesReady(object sender, AllFramesReadyEventArgs e)
        {
            try
            {
                _sensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Default;
                _sensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Dupa");
                this.Close();
            }

            kinectRegion.KinectSensor = _sensor;
        }

        private void ButtonOnClickXX(object sender, RoutedEventArgs e)
        {
            _sensor.Stop(); // nie ma tutaj stopKinect() więc jest łopatologicznie 
            _sensor.AudioSource.Stop();
            MainWindow wr = new MainWindow();
            wr.Show();
            this.Close();
        }
        private void ButtonOnClickA(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("A");
        }

        private void ButtonOnClickB(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("B");
        }

        private void ButtonOnClickC(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("C");
        }
        private void ButtonOnClickD(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("D");
        }

        private void ButtonOnClickE(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("E");
        }

        private void ButtonOnClickF(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("F");
        }
        private void ButtonOnClickG(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("G");
        }

        private void ButtonOnClickH(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("H");
        }

        private void ButtonOnClickI(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("I");
        }
        private void ButtonOnClickJ(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("J");
        }

        private void ButtonOnClickK(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("K");
        }

        private void ButtonOnClickL(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("L");
        }
        private void ButtonOnClickM(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("M");
        }

        private void ButtonOnClickN(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("N");
        }

        private void ButtonOnClickO(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("O");
        }
        private void ButtonOnClickQ(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("Q");
        }

        private void ButtonOnClickP(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("P");
        }

        private void ButtonOnClickR(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("R");
        }
        private void ButtonOnClickS(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("S");
        }

        private void ButtonOnClickT(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("T");
        }

        private void ButtonOnClickU(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("U");
        }
        private void ButtonOnClickW(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("W");
        }

        private void ButtonOnClickV(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("V");
        }

        private void ButtonOnClickX(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("X");
        }
        private void ButtonOnClickY(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("Y");
        }
        private void ButtonOnClickZ(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("Z");
        }

        private void ButtonOnClickSpac(object sender, RoutedEventArgs e)
        {
            textBox.AppendText(" ");
        }

        private void ButtonOnClickCof(object sender, RoutedEventArgs e)
        {
            textBox.AppendText(" ");
        }
        string connectionstring = "Server=217.173.198.143;Database=s86849_gra;Uid=ktokolwiek;Pwd=ujezevaje";
        string log;
        private void ButtonOnClickOK(object sender, RoutedEventArgs e)
        {
            log = textBox.Text;
            
           
            MySqlConnection connection = new MySqlConnection(connectionstring);
            MySqlCommand cmd;
            try {
                connection.Open();
            }
            catch(InvalidOperationException){
                MessageBox.Show("nie łączy się !!!!!");
            }
            Random r = new Random();
            try
            {

                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO uzytkownik(id_user,login,zalogowany) VALUES(@id,@log,@zal)";
                cmd.Parameters.AddWithValue("@id", (r.Next(0,200)));
                cmd.Parameters.AddWithValue("@log", log);
                cmd.Parameters.AddWithValue("@zal", true);
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            { throw; }
            finally {
                if (connection.State == System.Data.ConnectionState.Open)

                { connection.Close();
                    
                }

            }

        }

        
    }
}
