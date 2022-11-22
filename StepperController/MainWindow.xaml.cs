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
        private bool _busy;
        
        public MainWindow()
        {
            InitializeComponent();
            _serial = new SerialConnection();
            _serial.OnStep += SerialOnStep;
        }

        private void SerialOnStep(object sender, string e)
        {
            TxtStep.Text = e;
            _busy = e != "";
        }
        
        private void BtnSimpleCw_OnClick(object sender, RoutedEventArgs e)
        {
            SendMessage("Simple step (clockwise)", "scw");
        }

        private void BtnSimpleCc_OnClick(object sender, RoutedEventArgs e)
        {
            SendMessage("Simple step (counterclockwise)", "scc");
        }

        private void BtnFullCw_OnClick(object sender, RoutedEventArgs e)
        {
            SendMessage("Full step (clockwise)", "fcw");
        }

        private void BtnFullCc_OnClick(object sender, RoutedEventArgs e)
        {
            SendMessage("Full step (counterclockwise)", "fcc");
        }

        private void BtnHalfCw_OnClick(object sender, RoutedEventArgs e)
        {
            SendMessage("Half step (clockwise)", "hcw");
        }

        private void BtnHalfCc_OnClick(object sender, RoutedEventArgs e)
        {
            SendMessage("Half step (counterclockwise)", "hcc");
        }

        private void BtnStop_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "";
            _serial.SendMessage("stop");
        }

        private void SendMessage(string uiText, string sm)
        {
            if (_busy) return;
            TxtMode.Text = uiText;
            _serial.SendMessage(sm);
        }
    }
}
