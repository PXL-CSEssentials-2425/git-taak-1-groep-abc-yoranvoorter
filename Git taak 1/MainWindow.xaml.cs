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

namespace Git_taak_1
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

        private void pxlImage_MouseEnter(object sender, MouseEventArgs e)
        {
            MainGrid.Background = new SolidColorBrush(Colors.Black);
        }

        private void redBtn_Click(object sender, RoutedEventArgs e)
        {
            colorCodeText.Text = "#FF0000";
        }

        private void greenBtn_Click(object sender, RoutedEventArgs e)
        {
            colorCodeText.Text = "#008000";
        }

        private void yellowBtn_Click(object sender, RoutedEventArgs e)
        {
            colorCodeText.Text = "#FFFF00";
        }

        private void blueBtn_Click(object sender, RoutedEventArgs e)
        {
            colorCodeText.Text = "#0000FF";
        }
    }
}
