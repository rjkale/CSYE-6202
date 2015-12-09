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
    /// Interaction logic for CustomerBookingDetailsWindow.xaml
    /// </summary>
    public partial class CustomerBookingDetailsWindow : Window
    {
        Flight flight;
        Search search;
        Booking booking;

        public CustomerBookingDetailsWindow(Flight flight,Search search, Booking booking)
        {
            InitializeComponent();
            this.flight = flight;
            this.search = search;
            this.booking = booking;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            populateValues();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            CustomerCheckOutWindow check = new CustomerCheckOutWindow(flight, search);
            check.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            CustomerBookingPage cus = new CustomerBookingPage(flight, search);
            cus.Show();
        }

        
        private void populateValues()
        {

            string userName = search.username;
            CustomerDataClass cd = new CustomerDataClass();
            Person person = cd.getUserInfo(userName);

            
            txtBoxName.Text = person.name;
            txtBoxUsername.Text = person.username;
            txtBoxPhone.Text = person.phone;
            txtCIty.Text = person.city;
            txtBoxGender.Text = person.gender;
            txtBoxAge.Text = person.age;
            
        }
        
    }
}
