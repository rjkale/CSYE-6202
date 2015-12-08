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

namespace WpfApplicationFinalProject
{
    /// <summary>
    /// Interaction logic for CarrierHomePageWindow.xaml
    /// </summary>
    public partial class CarrierHomePageWindow : Window
    {
        FlightCarrier fc;
        public CarrierHomePageWindow(FlightCarrier fc)
        {
            InitializeComponent();
            this.fc = fc;
            loadDataGridview();
        }

        private void btnViewFlightBookins_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnAddFlight_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            AddFlightWindow addflight = new AddFlightWindow(fc);
            addflight.Show();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private  void loadDataGridview()
        {
            
            CarrierDataClass cdata = new CarrierDataClass();
            dataGrid.ItemsSource = cdata.loadDataGridView(fc);
        }
    }
}
