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
using WpfApplicationFinalProject.Class;

namespace WpfApplicationFinalProject.Customer
{
    /// <summary>
    /// Interaction logic for CustomerCheckOutWindow.xaml
    /// </summary>
    public partial class CustomerCheckOutWindow : Window
    {
        Flight flight;
        Search search;
        public CustomerCheckOutWindow(Flight flight, Search search)
        {
            InitializeComponent();
            this.flight = flight;
            this.search = search;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            CustomerBookingPage cb = new CustomerBookingPage( flight,  search);
            cb.Show();
        }
    }
}
