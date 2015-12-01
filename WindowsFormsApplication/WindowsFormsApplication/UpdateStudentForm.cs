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
    public partial class UpdateStudentForm : Form
    {
        private String SId;
        private String FName;
        private String LName;
        private String Dept;
        private String EnrolType;
 
        public UpdateStudentForm(String SId, String FName, String LName, String Dept, String EnrolType)
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
            txtBoxStudentId.Text = SId;
            txtBoxFirstName.Text = FName;
            txtBoxLastName.Text = LName;
            cboBoxDepartment.Text = Dept;

            if ("Full-Time" == EnrolType)
            {
                radioBtnFullTime.Checked = true;
            }
            else if ("Part-Time" == EnrolType)
            {
                radioBtnPartTime.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkforEmpty() == true)
            {
                if (MessageBox.Show("Are you sure you want to update this student?", "Edit Registration Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\Source\Repos\CSYE-6202_New\WindowsFormsApplication\WindowsFormsApplication\Database.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Student set FirstName ='"+ txtBoxFirstName.Text +"' , LastName =  '"+ txtBoxLastName.Text +"' , Department =  '"+ cboBoxDepartment.SelectedItem.ToString() +"' , Enrollment_Type =  '"+ GetRadioButtonValue().ToString()  +"'  where Student_ID = '"+ SId +"' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Student Updated");

                    HomePageForm hp = new HomePageForm();
                    hp.Show();
                    this.Close();
                }
                else
                {
                    ActiveForm.Close();
                    HomePageForm hp = new HomePageForm();
                    hp.Show();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields");
            }

            
        }

        
        private Boolean checkforEmpty()
        {
            if (txtBoxFirstName.Text == "")
            { return false; }
            else if (txtBoxLastName.Text == "")
            { return false; }
            else if (txtBoxStudentId.Text == "")
            { return false; }

            return true;
        }

        private string GetRadioButtonValue()
        {
            if (radioBtnFullTime.Checked)
            {
                return "Full-Time";
            }
            else
            {
                return "Part-Time";
            }
        }


    }
}
