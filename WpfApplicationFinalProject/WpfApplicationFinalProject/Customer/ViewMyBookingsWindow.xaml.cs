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
    /// Interaction logic for ViewMyBookingsWindow.xaml
    /// </summary>
    public partial class ViewMyBookingsWindow : Window
    {
        Person person;
        public ViewMyBookingsWindow(Person person)
        {
            InitializeComponent();
            this.person = person;
            loadDataGrid();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void loadDataGrid()
        {
            BookingDataClass bd = new BookingDataClass();
            dataGrid.ItemsSource = bd.loadBookedFlightsDataGridView(person);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count > 0)
            {
                try
                {
                    Booking booking = (Booking)dataGrid.SelectedValue;
                    BookingDataClass bd = new BookingDataClass();
                    if (bd.unBookFlightTable(booking, getClassTypeSeats()) == true)
                    {
                        MessageBox.Show("Flight Unbooked");
                        if (bd.updateBookingsTable(booking, getClassTypeSeats()) == true)
                        {
                            MessageBox.Show("Booking tale updated");
                            this.Close();
                            ViewMyBookingsWindow vm = new ViewMyBookingsWindow(person);
                            vm.Show();

                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("No values in the grid");
                }
                
            }
            else
            {
                MessageBox.Show("Please select a Booking");
            }
        }

        private string getClassTypeSeats()
        {
            Booking booking = (Booking)dataGrid.SelectedValue;
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
