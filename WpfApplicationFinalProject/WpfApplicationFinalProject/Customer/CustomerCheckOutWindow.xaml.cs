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
            if ((Convert.ToInt32(txtBoxCardNumber.Text)) < 10 )
                { return false; }
            else if ((Convert.ToInt32(txtBoxCardCode.Text)) < 3)
                { return false; }

            return false;
            
        }
    }
}
