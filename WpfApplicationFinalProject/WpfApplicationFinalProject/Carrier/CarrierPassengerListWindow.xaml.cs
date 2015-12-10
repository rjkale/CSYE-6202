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
using WpfApplicationFinalProject.DataFiles;

namespace WpfApplicationFinalProject.Carrier
{
    /// <summary>
    /// Interaction logic for CarrierPassengerListWindow.xaml
    /// </summary>
    public partial class CarrierPassengerListWindow : Window
    {
        Flight flight;
        FlightCarrier fc;

        public CarrierPassengerListWindow(Flight flight, FlightCarrier fc)
        {
            InitializeComponent();
            this.flight = flight;
            this.fc = fc;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            LoadDataGrid();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadDataGrid()
        {
            CustomerDataClass cd = new CustomerDataClass();
            dataGrid.ItemsSource = cd.loadCustomerBookingsDataGridView(flight,fc);
        }
    }
}
