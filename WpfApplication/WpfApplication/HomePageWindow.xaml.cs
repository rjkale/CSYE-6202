using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for HomePageWindow.xaml
    /// </summary>
    public partial class HomePageWindow : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\Source\Repos\CSYE-6202_New\WindowsFormsApplication\WindowsFormsApplication\Database.mdf;Integrated Security=True");

        private String FName;
        private String LName;
        private String SId;
        private String Dept;
        private String EnrolType;


        public HomePageWindow()
        {
            InitializeComponent();
            DataGridView();

        }

        private void DataGridView()
        {
           
            SqlCommand cmd = new SqlCommand("SELECT * from Student", con);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            dataGrid.ItemsSource = dt.DefaultView;


            cboBoxDepartment.Items.Add("Information Systems");
            cboBoxDepartment.Items.Add("International Affairs");
            cboBoxDepartment.Items.Add("Nursing");
            cboBoxDepartment.Items.Add("Pharmacy");
            cboBoxDepartment.Items.Add("Professional Studies");
            cboBoxDepartment.Items.Add("Psychology");
            cboBoxDepartment.Items.Add("Public Administration");

        }


        private void btnNewStudent_Click(object sender, RoutedEventArgs e)
        {
            NewStudentWindow ns = new NewStudentWindow();
            ns.Show();
        }

        private void btnRemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            RemoveStudentWindow2 rm = new RemoveStudentWindow2(SId,FName,LName,Dept,EnrolType);
            rm.ShowDialog();
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count > 0)
            {
                SId = ((DataRowView)dataGrid.SelectedItem).Row["Student_Id"].ToString();
                FName = ((DataRowView)dataGrid.SelectedItem).Row["FirstName"].ToString();
                LName = ((DataRowView)dataGrid.SelectedItem).Row["LastName"].ToString();
                Dept = ((DataRowView)dataGrid.SelectedItem).Row["Department"].ToString();
                EnrolType = ((DataRowView)dataGrid.SelectedItem).Row["Enrollment_Type"].ToString();

                txtBoxSudentId.Text = SId;
                txtBoxFirstName.Text = FName;
                txtBoxLastName.Text = LName;
                cboBoxDepartment.SelectedValue = Dept;

                if ("Full-Time" == EnrolType)
                {
                    radioBtnFullTime.IsChecked = true;
                    radioBtnPartTime.IsChecked = false;
                }
                else if ("Part-Time" == EnrolType)
                {
                    radioBtnPartTime.IsChecked = true;
                    radioBtnFullTime.IsChecked = false;
                }
            }
        }

        private void btnEditStudent_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            UpdateStudentWindow us = new UpdateStudentWindow(SId, FName, LName, Dept, EnrolType);
            us.Show();
        }
    }
}
