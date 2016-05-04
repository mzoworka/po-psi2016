using System;

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
using System.Globalization;


namespace TowerDefend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private KinectSensorChooser sensorChooser;
        public MainWindow()
        {
            InitializeComponent();
        }

        KinectSensor _sensor;
        private void Window_Loaded(object sender, RoutedEventArgs e) // opisuje co ma się dziać gdy okno zostaje załadowane
        {
            this.sensorChooser = new KinectSensorChooser(); // tworzy nowy "czujnik" 
            this.sensorChooserUi.KinectSensorChooser = this.sensorChooser; // podpisuje kinecta do czujnika na ekranie
            this.sensorChooser.Start(); // uruchomienie czujnika
            
            if (KinectSensor.KinectSensors.Count > 0) //sprawdzenie czy jest podłaczony kinect
            {
                _sensor = KinectSensor.KinectSensors[0]; // podpisanie pierwszego kinecta z listy do obsługiwanego przez appke

                if (_sensor.Status == KinectStatus.Connected)
                {
                    try
                    {
                                          
                        _sensor.ColorStream.Enable(); // uruchamia kamerkę
                        _sensor.DepthStream.Enable();   // uruchamia czujnik dali
                        _sensor.SkeletonStream.Enable(); // uruchamia szkielet
                        _sensor.AllFramesReady += new EventHandler<AllFramesReadyEventArgs>(_sensor_AllFramesReady); // uzupełnia działanie kinecta o to się dzieje w metodzie poniżej
                        _sensor.Start(); // uruchamia sensor
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("Dupa"); //wypisuje Dupa jeżeli nie wypali
                        this.Close(); // no i się wyłącza
                    }
                }
            }
        }

        private void _sensor_AllFramesReady(object sender, AllFramesReadyEventArgs e)
        {
            try {
                _sensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Default; // zczytuje z domyślnej odległości // tylko na widowsowskim działa NEAR
                _sensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30); // ustawia rezolucje czujnika dali
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Dupa2"); // druga Dupa j.w. 
                this.Close();
            }

            kinectRegion.KinectSensor = _sensor; // dopisuje KinectRegion do sensora
        }

        void stopKinect(KinectSensor sensor) // mówi samo za się
        {
            if(sensor != null)
            {
                sensor.Stop();
                sensor.AudioSource.Stop();
                sensorChooser.Stop();
            }
        }

        private void ButtonOnClick(object sender, RoutedEventArgs e)
        {
            stopKinect(_sensor); // stop dla kinecta by mógł się uruchomić spokojnie później
            nick n = new nick();
            n.Show();

            this.Close();
        }

        private void ButtonOnClick2(object sender, RoutedEventArgs e) // Wyłączenie prohgramu
        {
            this.Close();
            stopKinect(_sensor);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) // to nie ważna jak na ten moment // tutaj wrzucać to co ma sie dziać podczas wyłączenia okna
        {
           // stopKinect(_sensor);
        }

     
    }
}
