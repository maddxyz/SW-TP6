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

namespace GameOfThronesTournamentWPF
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

        private void ShowHouses_Click(object sender, RoutedEventArgs e)
        {
            List<HouseModel> l = new List<HouseModel>();

            l.Add(new HouseModel() { Name = "I", NbUnits = 450 });
            l.Add(new HouseModel() { Name = "Y", NbUnits = 231 });

            ResList.ItemsSource = l;
        }

        private void ShowChars_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowWars_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sho(object sender, RoutedEventArgs e)
        {

        }
    }
}
