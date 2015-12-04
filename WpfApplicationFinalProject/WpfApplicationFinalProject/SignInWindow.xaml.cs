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
using System.Data.SqlClient;
using System.Data;

namespace WpfApplicationFinalProject
{
    /// <summary>
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {

            if (txtBoxUsername.Text != "" && txtBoxPassword.Text != "")
            {
                //string userName = txtBoxUsername.Text;
                //string password = txtBoxPassword.Text;

                DBconnection objcon = new DBconnection();
                objcon.Connections();

                //string query = "Select * from LoginTable where userName = '" +this.txtBoxUsername.Text+ "' and password = '" + this.txtBoxPassword.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter("Select * from LoginTable where userName = '" + this.txtBoxUsername.Text + "' and password = '" + this.txtBoxPassword.Text + "' ", objcon.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Dt values is "+ dt.Rows[0][2].ToString());
                
                if ((dt.Rows[0][2]).ToString() == "admin")
                {
                    Console.WriteLine("Inside");
                    this.Hide();
                    AdminHomePageWindow admin = new AdminHomePageWindow();
                    admin.Show();
                }
                else if (dt.Rows[0][2].ToString() == "cus")
                {
                    this.Hide();
                    CustomerHomePageWindow customer = new CustomerHomePageWindow();
                    customer.Show();
                }

                else if (dt.Rows[0][2].ToString() == "ac")
                {
                    this.Hide();
                    CarrierHomePageWindow carrier = new CarrierHomePageWindow();
                    carrier.Show();
                }

                else
                {
                    MessageBox.Show("Incrorrect");
                }
                //objcon.con.Close();
            }
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            DBconnection objcon = new DBconnection();
            objcon.Connections();
            
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            string role = "admin";

            string query = "Select * from LoginTable where userName =@username and password =@password and Role = @role";
            SqlCommand cmd = new SqlCommand(query, objcon.con);
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@role", role));

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {

                MessageBox.Show("Login Sucessful");
                this.Hide();
                AdminHomePageWindow admin = new AdminHomePageWindow();
                admin.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Login");
            }
            objcon.con.Close();
        }

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            DBconnection objcon = new DBconnection();
            objcon.Connections();

            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            string role = "cus";

            string query = "Select * from LoginTable where userName =@username and password =@password and Role = @role" ;
            SqlCommand cmd = new SqlCommand(query, objcon.con);
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@role", role));

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Login Sucessful");
                this.Hide();
                CustomerHomePageWindow cust = new CustomerHomePageWindow();
                cust.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Login");
            }
            objcon.con.Close();
        }

        private void btnAirlines_Click(object sender, RoutedEventArgs e)
        {
            DBconnection objcon = new DBconnection();
            objcon.Connections();

            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            string role = "fc";

            string query = "Select * from LoginTable where userName =@username and password =@password and Role = @role";
            SqlCommand cmd = new SqlCommand(query, objcon.con);
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@role", role));

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {

                MessageBox.Show("Login Sucessful");
                this.Hide();
                CarrierHomePageWindow carrier = new CarrierHomePageWindow();
                carrier.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Login");
            }
            objcon.con.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
