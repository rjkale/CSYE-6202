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
using WpfApplicationFinalProject.Class;

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
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxUsername.Text != "" && passwordBox.Password != "")
            {
                //string userName =
                //string password =

                User user = new User();
                user.username = txtBoxUsername.Text; ;
                user.password = passwordBox.Password; 

                LoginDataClass login = new LoginDataClass();
                Person p = login.getUserType(user);

                if (!p.Equals(null))
                {
                    //MessageBox.Show("UserName is " + p.userName + "Password " + p.password + "Role " + p.Role);

                    if (p.Role.Equals("admin"))
                    {
                        Person p1 = new Person();
                        p1.username = p.username;
                        p1.name = p.name;

                        this.Hide();
                        AdminHomePageWindow admin = new AdminHomePageWindow(p1);
                        admin.Show();
                    }

                    else if (p.Role == "cus")
                    {
                        Person cust = new Person();
                        cust.username = p.username;
                        cust.name = p.name;

                        this.Hide();
                        CustomerHomePageWindow customer = new CustomerHomePageWindow(cust);
                        customer.Show();
                    }

                    else if (p.Role == "fc")
                    {
                        

                        FlightCarrier fc = new FlightCarrier();
                        fc.username = p.username;
                        fc.CompanyName =  p.name;
                        
                        this.Hide();
                        CarrierHomePageWindow carrier = new CarrierHomePageWindow(fc);
                        carrier.Show();
                    }

                    else
                    {
                        MessageBox.Show("Incrorrect username or Password! \n Please try again");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter values");
            }
        }

        //private void btnAdmin_Click(object sender, RoutedEventArgs e)
        //{
        //    DBconnection objcon = new DBconnection();
        //    objcon.Connections();

        //    string username = txtBoxUsername.Text;
        //    string password = txtBoxPassword.Text;
        //    string role = "admin";

        //    string query = "Select * from LoginTable where userName =@username and password =@password and Role = @role";
        //    SqlCommand cmd = new SqlCommand(query, objcon.con);
        //    cmd.Parameters.Add(new SqlParameter("@username", username));
        //    cmd.Parameters.Add(new SqlParameter("@password", password));
        //    cmd.Parameters.Add(new SqlParameter("@role", role));

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.HasRows == true)
        //    {

        //        MessageBox.Show("Login Sucessful");
        //        this.Hide();
        //        AdminHomePageWindow admin = new AdminHomePageWindow();
        //        admin.Show();

        //    }
        //    else
        //    {
        //        MessageBox.Show("Incorrect Login");
        //    }
        //    objcon.con.Close();
        //}

        //private void btnCustomer_Click(object sender, RoutedEventArgs e)
        //{
        //    DBconnection objcon = new DBconnection();
        //    objcon.Connections();

        //    string username = txtBoxUsername.Text;
        //    string password = txtBoxPassword.Text;
        //    string role = "cus";

        //    string query = "Select * from LoginTable where userName =@username and password =@password and Role = @role";
        //    SqlCommand cmd = new SqlCommand(query, objcon.con);
        //    cmd.Parameters.Add(new SqlParameter("@username", username));
        //    cmd.Parameters.Add(new SqlParameter("@password", password));
        //    cmd.Parameters.Add(new SqlParameter("@role", role));

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.HasRows == true)
        //    {
        //        MessageBox.Show("Login Sucessful");
        //        this.Hide();
        //        CustomerHomePageWindow cust = new CustomerHomePageWindow();
        //        cust.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Incorrect Login");
        //    }
        //    objcon.con.Close();
        //}

        //private void btnAirlines_Click(object sender, RoutedEventArgs e)
        //{
        //    DBconnection objcon = new DBconnection();
        //    objcon.Connections();

        //    string username = txtBoxUsername.Text;
        //    string password = txtBoxPassword.Text;
        //    string role = "fc";

        //    string query = "Select * from LoginTable where userName =@username and password =@password and Role = @role";
        //    SqlCommand cmd = new SqlCommand(query, objcon.con);
        //    cmd.Parameters.Add(new SqlParameter("@username", username));
        //    cmd.Parameters.Add(new SqlParameter("@password", password));
        //    cmd.Parameters.Add(new SqlParameter("@role", role));

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.HasRows == true)
        //    {

        //        MessageBox.Show("Login Sucessful");
        //        this.Hide();
        //        CarrierHomePageWindow carrier = new CarrierHomePageWindow();
        //        carrier.Show();

        //    }
        //    else
        //    {
        //        MessageBox.Show("Incorrect Login");
        //    }
        //    objcon.con.Close();
        //}

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
