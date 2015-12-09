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
    /// Interaction logic for CustomerBookingPage.xaml
    /// </summary>
    public partial class CustomerBookingPage : Window
    {
        Flight flight;
        public CustomerBookingPage(Flight flight)
        {
            InitializeComponent();
            this.flight = flight;
            MessageBox.Show(flight.flightName);
        }
    }
}
