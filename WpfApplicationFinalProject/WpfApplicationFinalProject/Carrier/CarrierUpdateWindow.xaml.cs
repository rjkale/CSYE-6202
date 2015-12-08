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
    /// Interaction logic for CarrierUpdateWindow.xaml
    /// </summary>
    public partial class CarrierUpdateWindow : Window
    {
        Flight flight = new Flight();
        FlightCarrier fc;
        public CarrierUpdateWindow(FlightCarrier fc, Flight flight)
        {
            InitializeComponent();
            this.flight = flight;
            this.fc = fc;
            populateCitiesCombobox();
            populateEconomySeatsCombobox();
            populateEconomyPlusSeatsCombobox();
            populateBusinessSeatsCombobox();
            populateHoursCombobox();
            populateValues();
        }

        private void populateValues()
        {
            txtBoxFlightName.Text = flight.flightName;
            txtBoxFlightNumber.Text = flight.flightnumber;
            coBoxSourceCity.SelectedValue = flight.sourceCity;
            coBoxDestinationCity.SelectedValue = flight.destinationCity;
            DatePicker.SelectedDate = DateTime.Parse(flight.date);
            coBoxDuration.SelectedIndex = Convert.ToInt32(flight.duration);
            txtFare.Text = flight.EconomyPrice;
            coBoxSeatsEconomy.SelectedIndex = Convert.ToInt32(flight.EconomySeats);
            coBoxSeatsEconomyPlus.SelectedIndex = Convert.ToInt32(flight.EconomyPlusSeats);
            coBoxSeatsBusinessClass.SelectedIndex = Convert.ToInt32(flight.BusinessSeats);
        }


        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            CarrierHomePageWindow car = new CarrierHomePageWindow(fc);
            car.Show();
        }

        private void populateEconomySeatsCombobox()
        {

            for (int i = 0; i < 150; i++)
            {
                coBoxSeatsEconomy.Items.Add(i);
            }

            coBoxSeatsEconomy.SelectedIndex = 1;
        }


        private void populateBusinessSeatsCombobox()
        {

            for (int i = 0; i < 10; i++)
            {
                coBoxSeatsBusinessClass.Items.Add(i);
            }

            coBoxSeatsBusinessClass.SelectedIndex = 1;
        }

        private void populateEconomyPlusSeatsCombobox()
        {

            for (int i = 0; i < 50; i++)
            {
                coBoxSeatsEconomyPlus.Items.Add(i);
            }

            coBoxSeatsEconomyPlus.SelectedIndex = 1;
        }


        private void populateHoursCombobox()
        {

            for (int i = 0; i < 25; i++)
            {
                coBoxDuration.Items.Add(i);
            }

            coBoxDuration.SelectedIndex = 1;
        }

        private void populateCitiesCombobox()
        {
            string[] str = new string[] { "NY", "Boston", "Chicago", "Rhode Island", "Houston", "Austin", "Seattle", "San Fransisco", "Washinton DC", "Los Angeles", "Philadelphia", "Portland", "Atlanta" };

            foreach (var item in str)
            {
                coBoxSourceCity.Items.Add(item);
                coBoxDestinationCity.Items.Add(item);

            }
            coBoxSourceCity.SelectedIndex = 2;
            coBoxDestinationCity.SelectedIndex = 2;

        }

        private void txtFare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key < Key.D0 || e.Key > Key.D9)
            {
                e.Handled = true;
            }
        }


        private Boolean checkforEmpty()
        {
            if (txtBoxFlightName.Text == "")
            { return false; }
            else if (txtBoxFlightNumber.Text == "")
            { return false; }
            else if (txtFare.Text == "")
            { return false; }
            else
                return true;
        }

        private void btnAddFlight_Click(object sender, RoutedEventArgs e)
        {
            
            Flight flight = new Flight();

            string userName = fc.username.ToString();
            string flightName = txtBoxFlightName.Text;
            string flightnumber = txtBoxFlightNumber.Text;
            string sourceCity = coBoxSourceCity.SelectedValue.ToString();
            string destinationCity = coBoxDestinationCity.SelectedValue.ToString();
            string date = DatePicker.SelectedDate.Value.Date.ToString();
            string duration = coBoxDuration.SelectedValue.ToString();
            string EconomyPrice = txtFare.Text;
            string economyPlusPrice = flight.geteconomyPlusPrice(EconomyPrice);
            string BusinessPrice = flight.getBusinessPrice(EconomyPrice);
            string EconomySeats = coBoxSeatsEconomy.SelectedValue.ToString();
            string EconomyPlusSeats = coBoxSeatsEconomyPlus.SelectedValue.ToString();
            string BusinessSeats = coBoxSeatsBusinessClass.SelectedValue.ToString();

            flight.userName = userName;
            flight.flightName = flightName;
            flight.flightnumber = flightnumber;
            flight.sourceCity = sourceCity;
            flight.destinationCity = destinationCity;
            flight.date = date;
            flight.duration = duration;
            flight.EconomyPrice = EconomyPrice;
            flight.economyPlusPrice = economyPlusPrice;
            flight.businessPrice = BusinessPrice;
            flight.EconomySeats = EconomySeats;
            flight.EconomyPlusSeats = EconomyPlusSeats;
            flight.BusinessSeats = BusinessSeats;

            

            if (checkforEmpty() == true)
            {
                CarrierDataClass cd = new CarrierDataClass();
                if (cd.updateCarrierTable(flight) == true)
                {
                    MessageBox.Show("Flight Updated successfully");
                }
                else
                {
                    MessageBox.Show("Unable to Update the Flight details");
                }
            }

            else
            {
                MessageBox.Show("Please fill all values");
            }
        }
    }
}
