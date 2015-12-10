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

namespace WpfApplicationFinalProject.Customer
{
    /// <summary>
    /// Interaction logic for CustomerSummaryPageWindow.xaml
    /// </summary>
    public partial class CustomerSummaryPageWindow : Window
    {
        Flight flight;
        Search search;
        Booking booking;
        public CustomerSummaryPageWindow(Flight flight, Search search, Booking booking)
        {
            InitializeComponent();
            this.flight = flight;
            this.search = search;
            this.booking = booking;
            updateTables();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void updateTables()
        {
            BookingDataClass book = new BookingDataClass();
            if (book.updateFlightsTable(flight, getFinalSeatsCount(),getClassTypeSeats()))
            {
                MessageBox.Show("Flight Tabel updated");
            }
            else
            {
                MessageBox.Show("Error updating flight tabel");
            }
            
        }



        private string getFinalSeatsCount()
        {
            string seats = booking.seats;
            string classtype = booking.classType;
            int seat = Convert.ToInt32(seats);
            int flightSeats = 0;

            if (classtype == "Economy")
            {
                flightSeats = flight.EconomySeats;
            }
            else if (classtype == "Economy Plus")
            {
                flightSeats = flight.EconomyPlusSeats;
            }
            else if (classtype == "Business")
            {
                flightSeats = flight.BusinessSeats;
            }

            
            int SeatCount = flightSeats - seat;
            return Convert.ToString(SeatCount);
        }


        private string getClassTypeSeats()
        {
            string classtype = booking.classType;

            if (classtype == "Economy")
            {
                return "EconomySeats";
            }
            else if (classtype == "Economy Plus")
            {
                return "EconomyPlusSeats";
            }
            else
                return "BusinessSeats";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
