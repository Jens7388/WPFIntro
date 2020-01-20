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

namespace Exercise4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        int counter;
        int totalClicksCounter;
        public MainWindow()
        {
            InitializeComponent();
        }

        //Upwards arrow button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            totalClicksCounter++;
            totalClicks.Text = totalClicksCounter.ToString();
            counter++;
            currentValue.Text = counter.ToString();
        }

        //Downwards arrow button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            totalClicksCounter++;
            totalClicks.Text = totalClicksCounter.ToString();
            counter--;
            currentValue.Text = counter.ToString();
        }
    }
}
