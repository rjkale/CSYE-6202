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

namespace WpfApplicationFinalProject.Admin
{
    /// <summary>
    /// Interaction logic for AdminViewAirlinesByCarrierWindow.xaml
    /// </summary>
    public partial class AdminViewAirlinesByCarrierWindow : Window
    {
        Person p = new Person();
        FlightCarrier fc;
        public AdminViewAirlinesByCarrierWindow(FlightCarrier fc)
        {
            InitializeComponent();
            this.fc = fc;
            p.username = fc.username;
            populateDataGrid();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AdminHomePageWindow admin = new AdminHomePageWindow(p);
            admin.Show();
        }

        private void populateDataGrid()
        {
            CarrierDataClass cdata = new CarrierDataClass();
            dataGrid.ItemsSource = cdata.loadDataGridView(fc);
        }
    }
}
