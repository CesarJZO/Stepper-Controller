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
using StepperController.Serial;

namespace StepperController
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SerialConnection _serial;
        public MainWindow()
        {
            InitializeComponent();
            _serial = new SerialConnection();
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
