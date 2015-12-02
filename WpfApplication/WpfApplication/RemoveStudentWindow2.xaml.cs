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

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for RemoveStudentWindow2.xaml
    /// </summary>
    public partial class RemoveStudentWindow2 : Window
    {
        private String SId;
        private String FName;
        private String LName;
        private String Dept;
        private String EnrolType;

        public RemoveStudentWindow2(String SId, String FName, String LName, String Dept, String EnrolType)
        {
            InitializeComponent();
            this.SId = SId;
            this.FName = FName;
            this.LName = LName;
            this.Dept = Dept;
            this.EnrolType = EnrolType;
            populate();
        }


        private void populate()
        {
            txtBoxSudentId.Text = SId;
            txtBoxFirstName.Text = FName;
            txtBoxLastName.Text = LName;
            cboBoxDepartment.SelectedItem = Dept;

            if ("Full-Time" == EnrolType)
            {
                radioBtnFullTime.IsChecked = true;
            }
            else if ("Part-Time" == EnrolType)
            {
                radioBtnPartTime.IsChecked = true;
            }
        }

        private void cleartext()
        {
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxSudentId.Clear();
            cboBoxDepartment.SelectedIndex = 0;
        }

        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = (MessageBox.Show("Are you sure you want to remove this student?", "Remove Student Registration Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question));
            
           if(result == MessageBoxResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\Source\Repos\CSYE-6202_New\WindowsFormsApplication\WindowsFormsApplication\Database.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Student where Student_Id ='" + SId + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Removed");

                cleartext();

                HomePageWindow hp = new HomePageWindow();
                hp.Show();
                this.Close();
            }
            else
            {
                this.Close();
                HomePageWindow hp = new HomePageWindow();
                hp.Show();
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            HomePageWindow hp = new HomePageWindow();
            hp.Show();
        }
    }
}
