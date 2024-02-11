using java.awt.@event;
using RobotWPFBitcoin.Driver;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace RobotWPFBitcoin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BitcoinDriver _bitcoin;
        private bool _startedRobot;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtDesiredValue.Text))
            {
                MessageBox.Show("Please, enter desired value");
            }
            else
            {
                _startedRobot = true;
                startBtn.Visibility = Visibility.Hidden;
                stopBtn.Visibility = Visibility.Visible;


                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    StartBitcoinCotacao();

                }).Start();
            }
        }

        private void StartBitcoinCotacao()
        {
            double desiredValue = 0;
            Dispatcher.BeginInvoke(() => desiredValue = Convert.ToDouble(txtDesiredValue.Text));

            _bitcoin = new BitcoinDriver();
            var cultureInfo = new CultureInfo("pt-BR");

            while (_startedRobot)
            {
                var value = _bitcoin.GetValueBitcoin();
                Dispatcher.BeginInvoke(() => lblValueBitcoin.Text = value.ToString("C", cultureInfo));

                if(_bitcoin.ChecksValueBitoinIsDesired(value, desiredValue))
                {
                    MessageBox.Show("OPA!!");
                    _startedRobot = false;
                    _bitcoin.CloseBrowser();
                }

                Thread.Sleep(TimeSpan.FromSeconds(5));
            }
        }

        private void stopBtn_Click(object sender, RoutedEventArgs e)
        {
            _startedRobot = false;
            startBtn.Visibility = Visibility.Visible;
            stopBtn.Visibility = Visibility.Hidden;

            _bitcoin.CloseBrowser();
        }

        private void buyBtn_Click(object sender, RoutedEventArgs e)
        {
            var mercado = new MercadoDriver();
            mercado.BuyBitcoin();
        }
    }
}
