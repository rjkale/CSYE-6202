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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplicationFinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            populateCombobox();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SignInWindow signIn = new SignInWindow();
            signIn.Show();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SignUp SignUp = new SignUp();
            SignUp.Show();
        }

        private void populateCombobox()
        {
            string[] str = new string[] { "NY", "Boston", "Chicago", "Rhode Island", "Houston", "Austin", "Seattle", "San Fransisco", "Washinton DC", "Los Angeles", "Philadelphia", "Portland", "Atlanta" };

            foreach (var item in str)
            {
                coBoxSourceCity.Items.Add(item);
                coBoxDestinationCity.Items.Add(item);

            }
            coBoxSourceCity.SelectedIndex = 2;
            coBoxDestinationCity.SelectedIndex = 2;


            string[] classs = new string[] {"Economy", "Economy Plus" , "Business"};

            foreach (var item in classs)
            {
                coboxClass.Items.Add(item);
            }
            coboxClass.SelectedIndex = 0;

            for (int i = 1; i < 10; i++)
            {
                coboxSeats.Items.Add(i);
            }coboxSeats.SelectedIndex = 0;

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (checkforvalues() == true)
            {

            }
            else
            {
                MessageBox.Show("Please select different Source and Destination cities \n OR \nSelect a date");
            }
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
    }
}
