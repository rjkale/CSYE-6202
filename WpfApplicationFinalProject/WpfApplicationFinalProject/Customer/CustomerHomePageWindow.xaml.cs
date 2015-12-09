using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApplicationFinalProject.Class;
using WpfApplicationFinalProject.Customer;
using WpfApplicationFinalProject.HomePage_and_Signup;

namespace WpfApplicationFinalProject
{
    /// <summary>
    /// Interaction logic for CustomerHomePageWindow.xaml
    /// </summary>
    public partial class CustomerHomePageWindow : Window
    {
        Person person;
        public CustomerHomePageWindow(Person cust)
        {
            InitializeComponent();
            this.person = cust;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            populateCombobox();
            DatePicker.SelectedDate = new DateTime(2015, 12, 11);

            
        }

       

        private void populateCombobox()
        {
            string[] str = new string[] { "NY", "Boston", "Chicago", "Rhode Island", "Houston", "Austin", "Seattle", "San Fransisco", "Washinton DC", "Los Angeles", "Philadelphia", "Portland", "Atlanta" };

            foreach (var item in str)
            {
                coBoxSourceCity.Items.Add(item);
                coBoxDestinationCity.Items.Add(item);

            }
            coBoxSourceCity.SelectedIndex = 1;
            coBoxDestinationCity.SelectedIndex = 2;


            string[] classs = new string[] { "Economy", "Economy Plus", "Business" };

            foreach (var item in classs)
            {
                coboxClass.Items.Add(item);
            }
            coboxClass.SelectedIndex = 0;

            for (int i = 1; i < 10; i++)
            {
                coboxSeats.Items.Add(i);
            }
            coboxSeats.SelectedIndex = 0;

        }



        private Boolean checkforvalues()
        {
            string source = coBoxSourceCity.SelectedValue.ToString();
            string destination = coBoxDestinationCity.SelectedValue.ToString();
            string date = DatePicker.ToString();
            if (source == destination)
            {
                return false;
            }
            else if (date == "")
            {
                return false;
            }


            return true;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (checkforvalues() == true)
            {
                Search search = new Search();
                search.sourceCity = coBoxSourceCity.SelectedValue.ToString();
                search.destinationCity = coBoxDestinationCity.SelectedValue.ToString();
                search.classType = coboxClass.SelectedValue.ToString();
                search.date = DatePicker.SelectedDate.Value.ToShortDateString();
                search.seats = coboxSeats.SelectedValue.ToString();


                CustomerSearchPageWindow c = new CustomerSearchPageWindow(search);
                c.Show();

            }
            else
            {
                MessageBox.Show("Please select different Source and Destination cities \n OR \nSelect a date");
            }
        }

        private void btn_Myprofile_Click(object sender, RoutedEventArgs e)
        {
            CustomerProfileWindow cp = new CustomerProfileWindow(person);
            cp.Show();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow m = new MainWindow();
            m.Show();
        }
    }
}
