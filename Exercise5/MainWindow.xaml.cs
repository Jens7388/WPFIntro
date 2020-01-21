using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Exercise5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        int boxPositionLeft;
        int boxPositionTop;
        int boxPositionRight;
        int boxPositionBottom;
        int counter;
        int countDown = 60;
        Random positionGenerator = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            boxPositionLeft = positionGenerator.Next(0, 800);
            boxPositionTop = positionGenerator.Next(0, 800);
            boxPositionRight = positionGenerator.Next(0, 800 - boxPositionLeft);
            boxPositionBottom = positionGenerator.Next(0, 800 - boxPositionTop);
            clickMe.Margin = new Thickness(boxPositionLeft, boxPositionTop, boxPositionRight, boxPositionBottom);

            counter++;
            score.Text = counter.ToString();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
