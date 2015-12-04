﻿using System;
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
            string gender = coBoxAge.SelectedValue.ToString();
            string age = coBoxAge.SelectedValue.ToString();

            DBconnection objcon = new DBconnection();
            objcon.Connections();
            if (Checkusername())
            {



                if (checkforEmpty() == true)
                {
                    string query = "Insert into CustomerDatabaseTable values(@username,@password,@name, @city, @phone, @gender, @age)";
                    SqlCommand cmd = new SqlCommand(query, objcon.con);

                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    cmd.Parameters.Add(new SqlParameter("@password", password));
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@city", city));
                    cmd.Parameters.Add(new SqlParameter("@phone", phone));
                    cmd.Parameters.Add(new SqlParameter("@gender", gender));
                    cmd.Parameters.Add(new SqlParameter("@age", age));
                    cmd.ExecuteNonQuery();
                    try
                    {
                        MessageBox.Show("User Created successful");
                        addtoLoginTable();
                        cleartext();
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
            DBconnection objcon = new DBconnection();
            objcon.Connections();
            
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            string name = txtBoxName.Text;
            string role = "cus";

            string query = "Insert into LoginTable values(@username,@password,@role,@name)";
            SqlCommand cmd = new SqlCommand(query, objcon.con);

            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@name", name));
            cmd.Parameters.Add(new SqlParameter("@role", role));
            cmd.ExecuteNonQuery();
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
