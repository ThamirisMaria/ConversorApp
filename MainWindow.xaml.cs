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

namespace ConversorApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnCparaF_Click(object sender, RoutedEventArgs e)
        {
            CelciusFahrenheit cfDialog = new CelciusFahrenheit();
            cfDialog.ShowDialog();
        }

        private void btnFparaC_Click(object sender, RoutedEventArgs e)
        {
            FahrenheitCelcius fcDialog = new FahrenheitCelcius();
            fcDialog.ShowDialog();
        }
    }
}
