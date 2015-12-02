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
    /// Interaction logic for UpdateStudentWindow.xaml
    /// </summary>
    public partial class UpdateStudentWindow : Window
    {

        private String SId;
        private String FName;
        private String LName;
        private String Dept;
        private String EnrolType;


        public UpdateStudentWindow(String SId, String FName, String LName, String Dept, String EnrolType)
        {
            InitializeComponent();
           
            this.SId = SId;
            this.FName = FName;
            this.LName = LName;
            this.Dept = Dept;
            this.EnrolType = EnrolType;
            populate();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (checkforEmpty() == true)
            {
                MessageBoxResult result = (MessageBox.Show("Are you sure you want to Update this student?", "Update Student Registration Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question));

                if (result == MessageBoxResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\Source\Repos\CSYE-6202_New\WindowsFormsApplication\WindowsFormsApplication\Database.mdf;Integrated Security=True");
                    con.Open();
                    String command = "Update Student set FirstName ='" + txtBoxFirstName.Text + "' , LastName =  '" + txtBoxLastName.Text + "' , Department =  '" + cboBoxDepartment.SelectedValue.ToString() + "' , Enrollment_Type =  '" + GetRadioButtonValue() + "'  where Student_ID = '" + SId + "' ";
                    SqlCommand cmd = new SqlCommand(command, con);
                    //SqlCommand cmd = new SqlCommand("Update Student set FirstName ='" + txtBoxFirstName.Text + "' , LastName =  '" + txtBoxLastName.Text + "' , Enrollment_Type =  '" + GetRadioButtonValue() + "'  where Student_ID = '" + SId + "' ", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Student Updated");
                    //Console.WriteLine("Combobox Item is "+cboBoxDepartment.SelectedValue.ToString());

                    this.Close();
                    HomePageWindow hp = new HomePageWindow();
                    hp.Show();

                }
                else
                {
                    this.Close();
                    HomePageWindow hp = new HomePageWindow();
                    hp.Show();
                }
            }
            else
            {
                MessageBox.Show("Please check the field some fields are empty");
            }
            
        }

        private void populate()
        {
            cboBoxDepartment.Items.Add("Information Systems");
            cboBoxDepartment.Items.Add("International Affairs");
            cboBoxDepartment.Items.Add("Nursing");
            cboBoxDepartment.Items.Add("Pharmacy");
            cboBoxDepartment.Items.Add("Professional Studies");
            cboBoxDepartment.Items.Add("Psychology");
            cboBoxDepartment.Items.Add("Public Administration");
            
            txtBoxSudentId.Text = SId;
            txtBoxFirstName.Text = FName;
            txtBoxLastName.Text = LName;
            cboBoxDepartment.SelectedValue = Dept;

            if ("Full-Time" == EnrolType)
            {
                radioBtnFullTime.IsChecked = true;
            }
            else if ("Part-Time" == EnrolType)
            {
                radioBtnPartTime.IsChecked = true;
            }
        }


        private Boolean checkforEmpty()
        {
            if (txtBoxFirstName.Text == "")
            { return false; }
            else if (txtBoxLastName.Text == "")
            { return false; }
            else if (txtBoxSudentId.Text == "")
            { return false; }

            return true;
        }


        private string GetRadioButtonValue()
        {
            if (radioBtnFullTime.IsChecked == true)
            {
                return "Full-Time";
            }
            else
            {
                return "Part-Time";
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
