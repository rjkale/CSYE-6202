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
        Search search;
        public CustomerBookingPage(Flight flight, Search search)
        {
            InitializeComponent();
            this.flight = flight;
            this.search = search;
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
            txtBoxSeats.Text = search.seats;
            txtBoxClass.Text = search.classType;
            int price = checkClassTypePrice() * Convert.ToInt16(search.seats);
            txtBoxFair.Text = Convert.ToString(price);
            txtBoxTaxes.Text = calculateTax();
            txtBoxTotalAmount.Text = totalFair();

        }

        private string totalFair()
        {
            double tax = Convert.ToDouble(calculateTax());
            int fair = checkClassTypePrice() * Convert.ToInt16(search.seats);
            double total = tax + Convert.ToDouble(fair);
            return Convert.ToString(total);
                
        }

        private string calculateTax()
        {

            int price = checkClassTypePrice() * Convert.ToInt16(search.seats);
            double Tax = 0.2 * price;
            return Convert.ToString(Tax);
        }

        private int checkClassTypePrice()
        {
            if (search.classType == "Economy")
            {
                return Convert.ToInt16(flight.economyPlusPrice);
            }
            else if (search.classType == "Economy Plus")
            {
                return Convert.ToInt16(flight.economyPlusPrice);
            }
            else if (search.classType == "Business")
            {
                return Convert.ToInt16(flight.businessPrice);
            }
            else
            {
                return 0;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            CustomerSearchPageWindow cs = new CustomerSearchPageWindow(search);
            cs.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Booking booking = new Booking();
            booking.flightCarrierUserName = flight.userName;
            booking.flightName = flight.flightName;
            booking.flightnumber = flight.flightnumber;
            booking.sourceCity = flight.sourceCity;
            booking.destinationCity = flight.destinationCity;
            booking.date = flight.date;
            booking.duration = flight.duration;
            booking.seats = search.seats;
            booking.classType = search.classType;
            booking.fair = Convert.ToString(checkClassTypePrice() * Convert.ToInt16(search.seats));
            booking.tax = calculateTax();
            booking.totalAmount = totalFair();
            //booking.customerUserName;
            //booking.flightCarrierUserName;


            this.Close();
            CustomerBookingDetailsWindow cus = new CustomerBookingDetailsWindow(flight, search, booking);
            cus.Show();

        }
    }
}
