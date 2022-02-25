using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace LotteryApplication
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
                        
        private void BtnRaffleClick(object sender, RoutedEventArgs e)
        {
            if (FirstTicket.Text != "" && LastTicket.Text != "")
            {
                int num1 = int.Parse(FirstTicket.Text);
                int num2 = int.Parse(LastTicket.Text);

                TicketList.Items.Clear();

                Random rnd = new Random();
                for (int i = 0; i <= 99; i++)


                    TicketList.Items.Add(rnd.Next(num1, num2));
            }
            else
            {
                MessageBox.Show("no valid Ticketnumber!");
            }                           
                        
        }

        private void BtnExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void BtnMinimizeClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        //private void FirstTicket_previewtextinput(object sender, TextCompositionEventArgs e)
        //{
        //    e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        //}

        //private void LastTicket_previewtextinput(object sender, TextCompositionEventArgs e)
        //{
        //    //e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        //}
    }
}
