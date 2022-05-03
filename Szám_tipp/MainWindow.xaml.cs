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

namespace Szám_tipp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static readonly Random rnd = new Random();
        int szam = rnd.Next(0, 10000);
        int min=0;
        int max= 10000;
        public MainWindow()
        {

            InitializeComponent();
            textblock_szam.Text = Convert.ToString(szam);
        }

        private void kisebb_Click(object sender, RoutedEventArgs e)
        {
            max = szam;
            szam = rnd.Next(min, max);
            textblock_szam.Text = Convert.ToString(szam);
        }

        private void nagyobb_Click(object sender, RoutedEventArgs e)
        {
            min = szam;
            szam = rnd.Next(max, max);
            textblock_szam.Text = Convert.ToString(szam);
        }

        private void megvan_Click(object sender, RoutedEventArgs e)
        {
            vege.Visibility = Visibility.Visible;
            nagyobb.Visibility = Visibility.Hidden;
            kisebb.Visibility = Visibility.Hidden;
            megvan.Visibility = Visibility.Hidden;
        }
    }
}
