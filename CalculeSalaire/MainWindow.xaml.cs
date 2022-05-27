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

namespace CalculeSalaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
          //  DataContext = new Gestion(); // regarder dans le code XAML pour savoir quel est le probleme
            cboDepartement.DataContext = new Gestion();
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int heure = (int)Slider.Value;
            txtheure.Text = heure.ToString();
            double t = double.Parse(txtHoraire.Text);
            DataContext = new maPaie(heure, t);
        }
    }
}
