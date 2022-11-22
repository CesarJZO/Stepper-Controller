using System.Windows;
using StepperController.Serial;

namespace StepperController
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly SerialConnection _serial;
        
        public MainWindow()
        {
            InitializeComponent();
            _serial = new SerialConnection();
            _serial.OnStep += SerialOnStep;
        }

        private void SerialOnStep(object sender, string e)
        {
            TxtStep.Text = e;
        }
        
        private void BtnSimpleCw_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "Simple step (clockwise)";
            _serial.SendMessage("scw");
        }

        private void BtnSimpleCc_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "Simple step (counterclockwise)";
            _serial.SendMessage("scc");
        }

        private void BtnFullCw_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "Full step (clockwise)";
            _serial.SendMessage("fcw");
        }

        private void BtnFullCc_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "Full step (counterclockwise)";
            _serial.SendMessage("fcc");
        }

        private void BtnHalfCw_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "Half step (clockwise)";
            _serial.SendMessage("hcw");
        }

        private void BtnHalfCc_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "Half step (counterclockwise)";
            _serial.SendMessage("hcc");
        }

        private void BtnStop_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "";
            _serial.SendMessage("stop");
        }
    }
}
