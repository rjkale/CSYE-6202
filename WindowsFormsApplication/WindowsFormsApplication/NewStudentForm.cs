using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication
{
    public partial class NewStudentForm : Form
    {
        String EnrollmentType;

        public NewStudentForm()
        {
            InitializeComponent();
            cboBoxDepartment.SelectedIndex = 1;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (checkforEmpty() == true)
            {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\Source\Repos\CSYE-6202_New\WindowsFormsApplication\WindowsFormsApplication\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(" Insert into Student (Student_ID,FirstName,LastName,Department,Enrollment_Type) VALUES('" + txtBoxStudentId.Text + "','" + txtBoxFirstName.Text + "' ,'" + txtBoxLastName.Text + "'  , '" + cboBoxDepartment.SelectedItem.ToString()+ "', '" + GetRadioButtonValue().ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            cleartext();
            MessageBox.Show("Student Registered");

            HomePageForm hp = new HomePageForm();
            hp.Refresh();

            }
            else
            {
                MessageBox.Show("Please fill all values");
            }
        }

        private string GetRadioButtonValue()
        {
            if (radioButtonFullTime.Checked)
            {
                return "Full-Time";
            }
            else
            {
                return "Part-Time";
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void cleartext()
        {
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxStudentId.Clear();
            cboBoxDepartment.SelectedIndex = 1;
        }

        private void radioButtonFullTime_CheckedChanged(object sender, EventArgs e)
        {
            EnrollmentType = "FullTime";
        }

        private void radioButtonPartTime_CheckedChanged(object sender, EventArgs e)
        {
            EnrollmentType = "PartTime";
        }

        private Boolean checkforEmpty()
        {
            if (txtBoxFirstName.Text == "")
            {return false;}
            else if (txtBoxLastName.Text == "")
            { return false; }
            else if (txtBoxStudentId.Text == "")
            { return false; }

            return true;
        }
    }
}
