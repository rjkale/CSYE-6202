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

            MessageBox.Show(flightName );
            MessageBox.Show(flightnumber);
            MessageBox.Show(sourceCity);
            MessageBox.Show(destinationCity);
            MessageBox.Show(date);
            MessageBox.Show(duration);
            MessageBox.Show(fare);
            MessageBox.Show(ClassType);
      
            DBconnection objcon = new DBconnection();
            objcon.Connections();

            if (checkforEmpty() == true)
            {
                try
                {
                    string query = "Insert into FlightDetailsTable values(@flightName,@flightnumber,@sourceCity,@destinationCity, @date, @duration,@fare,@ClassType,@NumberofSeats,@userName)";
                    SqlCommand cmd = new SqlCommand(query, objcon.con);

                    cmd.Parameters.Add(new SqlParameter("@flightName", flightName));
                    cmd.Parameters.Add(new SqlParameter("@flightnumber", flightnumber));
                    cmd.Parameters.Add(new SqlParameter("@sourceCity", sourceCity));
                    cmd.Parameters.Add(new SqlParameter("@destinationCity", destinationCity));
                    cmd.Parameters.Add(new SqlParameter("@date", date));
                    cmd.Parameters.Add(new SqlParameter("@duration", duration));
                    cmd.Parameters.Add(new SqlParameter("@fare", fare));
                    cmd.Parameters.Add(new SqlParameter("@ClassType", ClassType));
                    cmd.Parameters.Add(new SqlParameter("@NumberofSeats", NumberofSeats));
                    cmd.Parameters.Add(new SqlParameter("@userName", userName));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Flight Added Successfully");
                    this.Hide();
                    CarrierHomePageWindow ca = new CarrierHomePageWindow();
                    ca.Show();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error adding the user. Please try again" + ex);
                }
                objcon.con.Close();

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
