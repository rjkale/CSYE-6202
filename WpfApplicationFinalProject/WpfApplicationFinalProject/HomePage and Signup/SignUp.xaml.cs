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
using WpfApplicationFinalProject.DataFiles;

namespace WpfApplicationFinalProject
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
            populateVales();

        }


        private void populateVales()
        {
            coBoxGender.Items.Add("Male");
            coBoxGender.Items.Add("Female");
            coBoxGender.SelectedIndex = 0;


            for (int i = 1; i < 101; i++)
            {
                coBoxAge.Items.Add(i.ToString());
            }

            coBoxAge.SelectedIndex = 20;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
            labelMessage.Content = "";

        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            string name = txtBoxName.Text;
            string city = txtCIty.Text;
            string phone = txtBoxPhone.Text;
            string gender = coBoxGender.SelectedValue.ToString();
            string age = coBoxAge.SelectedValue.ToString();

            if (Checkusername())
            {
                
                if (checkforEmpty() == true)
                {

                    SignUpDataClass signup = new SignUpDataClass();
                    if (signup.addToUserLoginTable(username, password, name) == true)
                    {
                        if (signup.signupCustomer(username, password, name, city, phone, gender, age) == true)
                        {
                            MessageBox.Show("User Entered");
                            cleartext();
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid user name");
                        }
                    }
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
            else if (txtBoxPassword.Text == "")
            { return false; }
            else if (txtBoxName.Text == "")
            { return false; }
            else if (txtBoxPhone.Text == "")
            { return false; }
            else if (txtCIty.Text == "")
            { return false; }
            else
                return true;
        }


        private void cleartext()
        {
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
            txtBoxName.Clear();
            txtCIty.Clear();
            txtBoxPhone.Clear();
            coBoxAge.SelectedIndex = 1;
            coBoxAge.SelectedIndex = 21;
        }

        private void addtoLoginTable()
        {
            
        }

        private Boolean Checkusername()
        {
            DBconnection objcon = new DBconnection();
            objcon.Connections();
            string checkquery = "Select userId from CustomerDatabaseTable where userId = '" + txtBoxUsername.Text + "' ";
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
    }
}
