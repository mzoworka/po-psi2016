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
using Microsoft.Kinect.Toolkit.Controls;
using System.Globalization;

namespace TowerDefend
{
    /// <summary>
    /// Interaction logic for nick.xaml
    /// </summary>
    public partial class nick : Window
    {
        private KinectSensorChooser sensorChooser2;
        public nick()
        {
            InitializeComponent();
            Loaded += OnLoaded2;

        }
        private void OnLoaded2(object sender, RoutedEventArgs routedEventArgs)
        {
            this.sensorChooser2 = new KinectSensorChooser();
            this.sensorChooser2.KinectChanged += SensorChooserOnKinectChanged;
            this.sensorChooserUi.KinectSensorChooser = this.sensorChooser2;
            this.sensorChooser2.Start();
        }
        private void SensorChooserOnKinectChanged(object sender, KinectChangedEventArgs args)
        {
            bool error = false;
            if (args.OldSensor != null)
            {
                try
                {
                    args.OldSensor.DepthStream.Range = DepthRange.Default;
                    args.OldSensor.SkeletonStream.EnableTrackingInNearRange = false;
                    args.OldSensor.DepthStream.Disable();
                    args.OldSensor.SkeletonStream.Disable();
                }
                catch (InvalidOperationException)
                {
                    // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.
                    // E.g.: sensor might be abruptly unplugged.
                    error = true;
                }
            }

            if (args.NewSensor != null)
            {
                try
                {
                    args.NewSensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                    args.NewSensor.SkeletonStream.Enable();

                    try
                    {
                        args.NewSensor.DepthStream.Range = DepthRange.Near;
                        args.NewSensor.SkeletonStream.EnableTrackingInNearRange = true;
                        args.NewSensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Seated;
                    }
                    catch (InvalidOperationException)
                    {
                        // Non Kinect for Windows devices do not support Near mode, so reset back to default mode.
                        args.NewSensor.DepthStream.Range = DepthRange.Default;
                        args.NewSensor.SkeletonStream.EnableTrackingInNearRange = false;
                        error = true;
                    }
                }
                catch (InvalidOperationException)
                {
                    error = true;
                    // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.
                    // E.g.: sensor might be abruptly unplugged.
                }
            }
            if (!error)
            {
                kinectRegion.KinectSensor = args.NewSensor;

            }

        }
        public enum KinectStatus
        {
            Undefined,
            Disconnected,
            Connected,
            Initializing,
            Error,
            NotPowered,
            NotReady,
            DeviceNotGenuine,
            DeviceNotSupported,
            InsufficientBandwidth,
        }

        private void ButtonOnClickXX(object sender, RoutedEventArgs e)
        {
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

        private void ButtonOnClickOK(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("...");
        }
    }
}
