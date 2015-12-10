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
using WpfApplicationFinalProject.Class;
using WpfApplicationFinalProject.DataFiles;

namespace WpfApplicationFinalProject.Customer
{
    /// <summary>
    /// Interaction logic for CustomerProfileWindow.xaml
    /// </summary>
    public partial class CustomerProfileWindow : Window
    {
        Person person;
        public CustomerProfileWindow(Person person)
        {
            InitializeComponent();
            this.person = person;
            populateValues();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        //private void populateValues()
        //{
        //    txtBoxName.Text = person.name;
        //    txtBoxUsername.Text = person.username;
        //    txtBoxPhone.Text = person.phone;
        //    txtCIty.Text = person.city;
        //    txtBoxGender.Text = person.gender;
        //    txtBoxAge.Text = person.age;
        //}

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void populateValues()
        {

            string userName = person.username;
            CustomerDataClass cd = new CustomerDataClass();
            Person p = cd.getUserInfo(userName);


            txtBoxName.Text = p.name;
            txtBoxUsername.Text = p.username;
            txtBoxPhone.Text = p.phone;
            txtCIty.Text = p.city;
            txtBoxGender.Text = p.gender;
            txtBoxAge.Text = p.age;

        }

    }
}
