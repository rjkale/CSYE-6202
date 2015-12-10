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
    /// Interaction logic for CustomerCheckOutWindow.xaml
    /// </summary>
    public partial class CustomerCheckOutWindow : Window
    {
        Flight flight;
        Search search;
        Booking booking;
        public CustomerCheckOutWindow(Flight flight, Search search, Booking booking)
        {
            InitializeComponent();
            this.flight = flight;
            this.search = search;
            this.booking = booking;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            populateValues();
            txtBoxCardNumber.Text = "1234567890123456";

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            CustomerBookingPage cb = new CustomerBookingPage( flight,  search);
            cb.Show();
        }

        private void populateValues()
        {
            for (int i = 1; i <= 12 ; i++)
            {
                comboBoxMonth.Items.Add(i);
            }comboBoxMonth.SelectedIndex = 1;

            for (int i = 2015; i <=2020; i++)
            {
                comboBoxYear.Items.Add(i);
            }
            comboBoxYear.SelectedIndex = 1;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (checkForValues() == true)
            {
                if (checkForLength() == true)
                {
                    MessageBoxResult result = (MessageBox.Show("Are you sure you want to purchase the ticket \nwith you Card number ", "Purchase Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question));
                    if (result == MessageBoxResult.Yes)
                    {
                        PaymentDataClass pay = new PaymentDataClass();
                        if (pay.addToPayment(getPaymentDetails()) == true)
                        {
                            MessageBox.Show("Payment details added successfully");

                            BookingDataClass bd = new BookingDataClass();
                            if (bd.addtoBookings(getBookingDetails()) == true)
                            {
                                MessageBox.Show("Booking Done Successfully");
                                this.Close();
                                Booking book = getBookingDetails();
                                CustomerSummaryPageWindow cs = new CustomerSummaryPageWindow(flight,  search,  book);
                                cs.Show();
                            }
                            else
                            {
                                MessageBox.Show("Booking not done Please try again");
                            }

                        }
                        else
                        {
                            MessageBox.Show("unable to add payements");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid lengths for Card");
                }
                
            }
            else
            {
                MessageBox.Show("Please enter all values");
            }
            
        }

        private void txtBoxCardCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key < Key.D0 || e.Key > Key.D9)
            {
                e.Handled = true;
            }
        }

        private void txtBoxCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key < Key.D0 || e.Key > Key.D9)
            {
                e.Handled = true;
            }
        }

        private Boolean checkForValues()
        {
            if (txtBoxCardName.Text == "")
            { return false; }
            else if (txtBoxCardNumber.Text == "")
            { return false; }
            else if (txtBoxCardCode.Text == "")
            { return false; }
            else return true;
        }

        private Boolean checkForLength()
        {
            int a;
            if (int.TryParse(txtBoxCardNumber.Text, out a))
            {
                if (a < 16)
                { return false; }
            }          
            
            else if (int.TryParse(txtBoxCardCode.Text, out a))
            {
                if (a < 3)
                { return false; }
            }
            return true;
        }

        private PaymentDetails getPaymentDetails()
        {
            PaymentDetails pay = new PaymentDetails();
            pay.cardNumber = txtBoxCardNumber.Text;
            pay.expiryMonth = comboBoxMonth.SelectedValue.ToString();
            pay.expiryYear = comboBoxYear.SelectedValue.ToString();
            pay.CustomerUserName = txtBoxCardName.Text;
            pay.cardCVV = txtBoxCardCode.Text;
            pay.cardName = txtBoxCardName.Text;
            return pay;
        }

        private Booking getBookingDetails()
        {
            Booking b = new Booking();
            b.customerUserName = booking.customerUserName;
            b.customerName = booking.customerName;
            b.customerPhone = booking.customerPhone;
            b.flightCarrierUserName = booking.flightCarrierUserName;
            b.flightName = booking.flightName;
            b.flightnumber = booking.flightnumber;
            b.sourceCity = booking.sourceCity;
            b.destinationCity = booking.destinationCity;
            b.date = booking.date;
            b.duration = booking.duration;
            b.seats = booking.seats;
            b.classType = booking.classType;
            b.fair = booking.fair;
            b.tax = booking.tax;
            b.totalAmount = booking.totalAmount;
            DateTime now = DateTime.Now;
            b.timStamp = now.ToString();
            
            return b;
        }
    }
}
