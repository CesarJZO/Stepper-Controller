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

namespace StepperController
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSimpleCw_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "Simple step (clockwise)";
        }

        private void BtnSimpleCc_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "Simple step (counterclockwise)";
        }

        private void BtnFullCw_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "Full step (clockwise)";
        }

        private void BtnFullCc_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "Full step (counterclockwise)";
        }

        private void BtnHalfCw_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "Half step (clockwise)";
        }

        private void BtnHalfCc_OnClick(object sender, RoutedEventArgs e)
        {
            TxtMode.Text = "Half step (counterclockwise)";
        }
    }
}
