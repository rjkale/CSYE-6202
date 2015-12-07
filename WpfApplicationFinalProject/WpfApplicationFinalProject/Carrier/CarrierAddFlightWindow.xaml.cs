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
using WpfApplicationFinalProject.DataFiles;

namespace WpfApplicationFinalProject
{
    /// <summary>
    /// Interaction logic for AddFlightWindow.xaml
    /// </summary>
    public partial class AddFlightWindow : Window
    {
        public AddFlightWindow()
        {
            InitializeComponent();
            populateCitiesCombobox();
            populateClassCombobox();
            populateSeatsCombobox();
            populateHoursCombobox();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            CarrierHomePageWindow car = new CarrierHomePageWindow();
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

        private void populateClassCombobox()
        {
            string[] str = new string[] { "Economy", "Economy PLus", "Business"};

            foreach (var item in str)
            {
                coBoxClass.Items.Add(item);
            }
            coBoxClass.SelectedIndex = 1;
        }

        private void textBox_Copy5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key < Key.D0 || e.Key > Key.D9)
            {
                e.Handled = true;
            }
        }

        private void populateSeatsCombobox()
        {
          
            for (int i = 0; i < 150; i++)
            {
                coBoxSeats.Items.Add(i);
            }

            coBoxSeats.SelectedIndex = 1;
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
            string flightName = txtBoxFlightName.Text;
            string flightnumber = txtBoxFlightNumber.Text;
            string sourceCity = coBoxSourceCity.SelectedValue.ToString();
            string destinationCity = coBoxDestinationCity.SelectedValue.ToString();
            string date = "date";
                //DatePicker.SelectedDateProperty.ToString();
            string duration = coBoxDuration.SelectedValue.ToString();
            string fare = txtFare.Text;
            string ClassType = coBoxClass.SelectedValue.ToString();
            string NumberofSeats = coBoxSeats.SelectedValue.ToString();
            string userName = "user";

            if (checkforEmpty() == true)
            {
                CarrierDataClass cd = new CarrierDataClass();
                if (cd.addToCarrierTable(flightName, flightnumber, sourceCity, destinationCity, date, duration, fare, ClassType, NumberofSeats, userName) == true)
                {
                    MessageBox.Show("Flight Added successfully");

                }
                else
                {
                    MessageBox.Show("Unable to enter the Flight details");
                    MessageBox.Show("flightName" + flightName + "\nflightnumber" + flightnumber + " sourceCity " + sourceCity + " destinationCity " + destinationCity +" date "+ date + " duration " + duration+ " fare " + fare  + " ClassType " + ClassType+ " NumberofSeats " + NumberofSeats + " userName " + userName);
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
            else
                return true;
        }
    }
 }
