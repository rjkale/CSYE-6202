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
using WpfApplicationFinalProject.Carrier;
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
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnViewFlightBookins_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count > 0)
            {
                Flight flight = (Flight)dataGrid.SelectedValue;
                this.Close();
                CarrierViewFlightBookingsWindow car = new CarrierViewFlightBookingsWindow(flight, fc);
                car.Show();
            }
            else
            {
                MessageBox.Show("Please select a field");
            }

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

        private void btnUpdateFlight_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count > 0)
            {
                Flight flight = (Flight)dataGrid.SelectedValue;
                CarrierDataClass ca = new CarrierDataClass();

                MessageBoxResult result = (MessageBox.Show("Are you sure you want to remove this Flight?", "Remove Flight Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question));
                if (result == MessageBoxResult.Yes)
                {
                    if (ca.removeCarrier(flight) == true)
                    {
                        MessageBox.Show("Flight Removed");
                        this.Close();
                        CarrierHomePageWindow car = new CarrierHomePageWindow(fc);
                        car.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete the fligt");
                    }                    
                }    
            }
            else
            {
                MessageBox.Show("Please select a field");
            }
        }

        private void btnUpdateFlight_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count > 0)
            {
                Flight flight = (Flight)dataGrid.SelectedValue;
                this.Close();
                CarrierUpdateWindow car = new CarrierUpdateWindow(fc, flight);
                car.Show();
            }
            else
            {
                MessageBox.Show("Please select a field");
            }
        }
    }
}
