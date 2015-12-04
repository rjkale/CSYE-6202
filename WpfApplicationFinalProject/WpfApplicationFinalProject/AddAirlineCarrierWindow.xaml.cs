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
    /// Interaction logic for AddAirlineCarrierWindow.xaml
    /// </summary>
    public partial class AddAirlineCarrierWindow : Window
    {
        public AddAirlineCarrierWindow()
        {
            InitializeComponent();
        }

        private void btnAddCarrier_Click(object sender, RoutedEventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = passwordBox.Password;
            string companyName = txtBoxCompanyName.Text;
            string role = "ac";


            DBconnection objcon = new DBconnection();
            objcon.Connections();


            if (Checkusername())
            {



                if (checkforEmpty() == true)
                {
                    try
                    {
                        string query = "Insert into LoginTable values(@username,@password,@name,@role)";
                        SqlCommand cmd = new SqlCommand(query, objcon.con);

                        cmd.Parameters.Add(new SqlParameter("@username", username));
                        cmd.Parameters.Add(new SqlParameter("@password", password));
                        cmd.Parameters.Add(new SqlParameter("@name", companyName));
                        cmd.Parameters.Add(new SqlParameter("@role", role));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Airline Carrier Created successful");
                        this.Hide();
                        AdminHomePageWindow ahome = new AdminHomePageWindow();
                        ahome.Show();

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

        }


        private Boolean checkforEmpty()
        {
            if (txtBoxUsername.Text == "")
            { return false; }
            else if (passwordBox.Password == "")
            { return false; }
            else if (txtBoxCompanyName.Text == "")
            { return false; }
            else
              return true;
        }


        private Boolean Checkusername()
        {
            DBconnection objcon = new DBconnection();
            objcon.Connections();
            string checkquery = "Select userName from LoginTable where userName = '" + txtBoxUsername.Text + "' ";
            SqlCommand cmdCheckQuery = new SqlCommand(checkquery, objcon.con);
            SqlDataReader dr = cmdCheckQuery.ExecuteReader();

            if (dr.HasRows == true)
            {
                labelMessage.Content = "User Already Exist! ";
                dr.Close();
                objcon.con.Close();
                return false;
            }
            return true;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AdminHomePageWindow ahome = new AdminHomePageWindow();
            ahome.Show();
        }
    }

 }

