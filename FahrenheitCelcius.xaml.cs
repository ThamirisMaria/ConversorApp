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
using System.Windows.Shapes;

namespace ConversorApp
{
    /// <summary>
    /// Lógica interna para FahrenheitCelcius.xaml
    /// </summary>
    public partial class FahrenheitCelcius : Window
    {

        private double C = 0.0, F = 0.0;
        private string CasaDecimal = " ";
        private bool convertido = false;
        public FahrenheitCelcius()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (convertido)
            {
                MessageBox.Show("FAVOR, CLICAR EM 'C' PARA LIMPAR A TELA E INICIAR UMA NOVA CONVERSÃO!", "CONVERSÃO JÁ REALIZADA!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (CasaDecimal == " ")
                {
                    F = (F * 10) + 1;
                    txtTela.Text = F.ToString() + "°";
                }
                else if (CasaDecimal == ",")
                {
                    F = F + 0.1;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,";
                }
                else if (CasaDecimal == ",,")
                {
                    F = F + 0.01;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,,";
                }
                else if (CasaDecimal == ",,,")
                {
                    MessageBox.Show("FAVOR CLICAR EM '=' PARA CONVERTER A TEMPERATURA!", "NÚMERO MÁXIMO DE CASAS DECIMAIS ATINGIDO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (convertido)
            {
                MessageBox.Show("FAVOR, CLICAR EM 'C' PARA LIMPAR A TELA E INICIAR UMA NOVA CONVERSÃO!", "CONVERSÃO JÁ REALIZADA!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (CasaDecimal == " ")
                {
                    F = (F * 10) + 2;
                    txtTela.Text = F.ToString() + "°";
                }
                else if (CasaDecimal == ",")
                {
                    F = F + 0.2;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,";
                }
                else if (CasaDecimal == ",,")
                {
                    F = F + 0.02;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,,";
                }
                else if (CasaDecimal == ",,,")
                {
                    MessageBox.Show("FAVOR CLICAR EM '=' PARA CONVERTER A TEMPERATURA!", "NÚMERO MÁXIMO DE CASAS DECIMAIS ATINGIDO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (convertido)
            {
                MessageBox.Show("FAVOR, CLICAR EM 'C' PARA LIMPAR A TELA E INICIAR UMA NOVA CONVERSÃO!", "CONVERSÃO JÁ REALIZADA!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (CasaDecimal == " ")
                {
                    F = (F * 10) + 3;
                    txtTela.Text = F.ToString() + "°";
                }
                else if (CasaDecimal == ",")
                {
                    F = F + 0.3;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,";
                }
                else if (CasaDecimal == ",,")
                {
                    F = F + 0.03;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,,";
                }
                else if (CasaDecimal == ",,,")
                {
                    MessageBox.Show("FAVOR CLICAR EM '=' PARA CONVERTER A TEMPERATURA!", "NÚMERO MÁXIMO DE CASAS DECIMAIS ATINGIDO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (convertido)
            {
                MessageBox.Show("FAVOR, CLICAR EM 'C' PARA LIMPAR A TELA E INICIAR UMA NOVA CONVERSÃO!", "CONVERSÃO JÁ REALIZADA!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (CasaDecimal == " ")
                {
                    F = (F * 10) + 4;
                    txtTela.Text = F.ToString() + "°";
                }
                else if (CasaDecimal == ",")
                {
                    F = F + 0.4;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,";
                }
                else if (CasaDecimal == ",,")
                {
                    F = F + 0.04;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,,";
                }
                else if (CasaDecimal == ",,,")
                {
                    MessageBox.Show("FAVOR CLICAR EM '=' PARA CONVERTER A TEMPERATURA!", "NÚMERO MÁXIMO DE CASAS DECIMAIS ATINGIDO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (convertido)
            {
                MessageBox.Show("FAVOR, CLICAR EM 'C' PARA LIMPAR A TELA E INICIAR UMA NOVA CONVERSÃO!", "CONVERSÃO JÁ REALIZADA!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (CasaDecimal == " ")
                {
                    F = (F * 10) + 5;
                    txtTela.Text = F.ToString() + "°";
                }
                else if (CasaDecimal == ",")
                {
                    F = F + 0.5;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,";
                }
                else if (CasaDecimal == ",,")
                {
                    F = F + 0.05;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,,";
                }
                else if (CasaDecimal == ",,,")
                {
                    MessageBox.Show("FAVOR CLICAR EM '=' PARA CONVERTER A TEMPERATURA!", "NÚMERO MÁXIMO DE CASAS DECIMAIS ATINGIDO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (convertido)
            {
                MessageBox.Show("FAVOR, CLICAR EM 'C' PARA LIMPAR A TELA E INICIAR UMA NOVA CONVERSÃO!", "CONVERSÃO JÁ REALIZADA!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (CasaDecimal == " ")
                {
                    F = (F * 10) + 6;
                    txtTela.Text = F.ToString() + "°";
                }
                else if (CasaDecimal == ",")
                {
                    F = F + 0.6;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,";
                }
                else if (CasaDecimal == ",,")
                {
                    F = F + 0.06;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,,";
                }
                else if (CasaDecimal == ",,,")
                {
                    MessageBox.Show("FAVOR CLICAR EM '=' PARA CONVERTER A TEMPERATURA!", "NÚMERO MÁXIMO DE CASAS DECIMAIS ATINGIDO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (convertido)
            {
                MessageBox.Show("FAVOR, CLICAR EM 'C' PARA LIMPAR A TELA E INICIAR UMA NOVA CONVERSÃO!", "CONVERSÃO JÁ REALIZADA!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (CasaDecimal == " ")
                {
                    F = (F * 10) + 7;
                    txtTela.Text = F.ToString() + "°";
                }
                else if (CasaDecimal == ",")
                {
                    F = F + 0.7;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,";
                }
                else if (CasaDecimal == ",,")
                {
                    F = F + 0.07;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,,";
                }
                else if (CasaDecimal == ",,,")
                {
                    MessageBox.Show("FAVOR CLICAR EM '=' PARA CONVERTER A TEMPERATURA!", "NÚMERO MÁXIMO DE CASAS DECIMAIS ATINGIDO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (convertido)
            {
                MessageBox.Show("FAVOR, CLICAR EM 'C' PARA LIMPAR A TELA E INICIAR UMA NOVA CONVERSÃO!", "CONVERSÃO JÁ REALIZADA!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (CasaDecimal == " ")
                {
                    F = (F * 10) + 8;
                    txtTela.Text = F.ToString() + "°";
                }
                else if (CasaDecimal == ",")
                {
                    F = F + 0.8;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,";
                }
                else if (CasaDecimal == ",,")
                {
                    F = F + 0.08;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,,";
                }
                else if (CasaDecimal == ",,,")
                {
                    MessageBox.Show("FAVOR CLICAR EM '=' PARA CONVERTER A TEMPERATURA!", "NÚMERO MÁXIMO DE CASAS DECIMAIS ATINGIDO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (convertido)
            {
                MessageBox.Show("FAVOR, CLICAR EM 'C' PARA LIMPAR A TELA E INICIAR UMA NOVA CONVERSÃO!", "CONVERSÃO JÁ REALIZADA!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (CasaDecimal == " ")
                {
                    F = (F * 10) + 9;
                    txtTela.Text = F.ToString() + "°";
                }
                else if (CasaDecimal == ",")
                {
                    F = F + 0.9;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,";
                }
                else if (CasaDecimal == ",,")
                {
                    F = F + 0.09;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,,";
                }
                else if (CasaDecimal == ",,,")
                {
                    MessageBox.Show("FAVOR CLICAR EM '=' PARA CONVERTER A TEMPERATURA!", "NÚMERO MÁXIMO DE CASAS DECIMAIS ATINGIDO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (convertido)
            {
                MessageBox.Show("FAVOR, CLICAR EM 'C' PARA LIMPAR A TELA E INICIAR UMA NOVA CONVERSÃO!", "CONVERSÃO JÁ REALIZADA!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (CasaDecimal == " ")
                {
                    F = (F * 10) + 0;
                    txtTela.Text = F.ToString() + "°";
                }
                else if (CasaDecimal == ",")
                {
                    F = F + 0.0;
                    txtTela.Text = F.ToString() + "°";
                    CasaDecimal = ",,";
                }
                else if (CasaDecimal == ",,")
                {
                    F = F + 0.00;
                    txtTela.Text = F.ToString() + "°";
                }
                else if (CasaDecimal == ",,,")
                {
                    MessageBox.Show("FAVOR CLICAR EM '=' PARA CONVERTER A TEMPERATURA!", "NÚMERO MÁXIMO DE CASAS DECIMAIS ATINGIDO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        private void btnPonto_Click(object sender, RoutedEventArgs e)
        {
            if (CasaDecimal == " ")
            {
                CasaDecimal = ",";
            }
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            if (convertido)
            {
                MessageBox.Show("FAVOR, CLICAR EM 'C' PARA LIMPAR A TELA E INICIAR UMA NOVA CONVERSÃO!", "CONVERSÃO JÁ REALIZADA!", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            else
            {
                C = (F - 32) / 1.8;
                txtTela.Text = C.ToString() + "°";
                convertido = true;
            }
        }

        private void btnPositivoNegativo_Click(object sender, RoutedEventArgs e)
        {

            if (convertido)
            {
                MessageBox.Show("FAVOR, CLICAR EM 'C' PARA LIMPAR A TELA E INICIAR UMA NOVA CONVERSÃO!", "CONVERSÃO JÁ REALIZADA!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                F *= -1;
                txtTela.Text = F.ToString() + "°";
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            C = 0.0;
            F = 0.0;
            CasaDecimal = " ";
            convertido = false;
            txtTela.Text = C.ToString() + "°";
        }
    }
}
