using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace WpfApplicationFinalProject
{
    /// <summary>
    /// Interaction logic for AddFlightWindow.xaml
    /// </summary>
    public partial class AddFlightWindow : Window
    {
        FlightCarrier fc;

        public AddFlightWindow(FlightCarrier fc)
        {
            InitializeComponent();
            populateCitiesCombobox();
            populateEconomySeatsCombobox();
            populateEconomyPlusSeatsCombobox();
            populateBusinessSeatsCombobox();
            txtBoxFlightName.Text = fc.CompanyName;
            
            populateHoursCombobox();
            this.fc = fc;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            CarrierHomePageWindow car = new CarrierHomePageWindow(fc);
            car.Show();
        }

        private  void populateCitiesCombobox()
        {
            string[] str = new string[] { "NY", "Boston", "Chicago", "Rhode Island", "Houston", "Austin", "Seattle", "San Fransisco", "Washinton DC", "Los Angeles" , "Philadelphia", "Portland", "Atlanta" };

            foreach (var item in str)
            {
                coBoxSourceCity.Items.Add(item);
                coBoxDestinationCity.Items.Add(item);
                
            }
            coBoxSourceCity.SelectedIndex = 2;
            coBoxDestinationCity.SelectedIndex = 2;
        }

        /*
        private void populateClassCombobox()
        {
            string[] str = new string[] { "Economy", "Economy PLus", "Business"};

            foreach (var item in str)
            {
                coBoxClass.Items.Add(item);
            }
            coBoxClass.SelectedIndex = 1;
        }
        */

        private void textBox_Copy5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key < Key.D0 || e.Key > Key.D9)
            {
                e.Handled = true;
            }
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

        private void btnAddFlight_Click(object sender, RoutedEventArgs e)
        {
            if (checkforEmpty() == true)
            {

                Flight flight = new Flight();

            string userName = fc.username.ToString();
            string flightName = txtBoxFlightName.Text;
            string flightnumber = userName+txtBoxFlightNumber.Text;
            string sourceCity = coBoxSourceCity.SelectedValue.ToString();
            string destinationCity = coBoxDestinationCity.SelectedValue.ToString();
            string date = DatePicker.SelectedDate.Value.ToShortDateString();
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
            

            
                CarrierDataClass cd = new CarrierDataClass();
                if (cd.addToCarrierTable(flight) == true)
                {
                    MessageBox.Show("Flight Added successfully");
                }
                else
                {
                    MessageBox.Show("Unable to enter the Flight details");
                    MessageBox.Show("flightName" + flightName + "\nflightnumber" + flightnumber + " sourceCity " + sourceCity + " destinationCity " + destinationCity +" date "+ date + " duration " + duration+ "userName "+ userName);
                }
            }

            else
            {
                MessageBox.Show("Please fill all values");
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
            else if(DatePicker.Text == "")
            {return false;}
            else
            return true;
        }

        private void DateT_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
 }
