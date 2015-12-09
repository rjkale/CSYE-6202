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

namespace WpfApplicationFinalProject.Carrier
{
    /// <summary>
    /// Interaction logic for CarrierViewFlightBookingsWindow.xaml
    /// </summary>
    public partial class CarrierViewFlightBookingsWindow : Window
    {
        Flight flight = new Flight();
        FlightCarrier fc;
        public CarrierViewFlightBookingsWindow(Flight flight, FlightCarrier fc)
        {
            InitializeComponent();
            this.flight = flight;
            this.fc = fc;
            populateValues();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void populateValues()
        {

            txtBoxFlightName.Text = flight.flightName;
            txtBoxFlightNumber.Text = flight.flightnumber;
            txtBoxSourceCity.Text = flight.sourceCity;
            txtBoxFDestinationCity.Text = flight.destinationCity;
            txtBoxTravelDate.Text = flight.date;
            txtBoxFlightDuration.Text = flight.duration;
            txtBoxEconomyPlusSeats.Text = flight.EconomyPlusSeats;
            txtBoxFEconomySeats.Text = flight.EconomySeats;
            txtBoxBusinessSeats.Text = flight.BusinessSeats;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            CarrierHomePageWindow home = new CarrierHomePageWindow(fc);
            home.Show();
        }
    }
}
