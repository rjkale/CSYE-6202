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
    public partial class RemoveStudentForm : Form
    {
        private String SId;
        private String FName;
        private String LName;
        private String Dept;
        private String EnrolType;

        public RemoveStudentForm(String SId, String FName, String LName, String Dept, String EnrolType)
        {
            InitializeComponent();
            this.SId = SId;
            this.FName = FName;
            this.LName = LName;
            this.Dept = Dept;
            this.EnrolType = EnrolType;
            populate();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            HomePageForm hp = new HomePageForm();
            hp.Show();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this student?", "RemoveStudent Registration Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\Source\Repos\CSYE-6202_New\WindowsFormsApplication\WindowsFormsApplication\Database.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Student where Student_Id ='" + SId + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Removed");

                cleartext();
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


        private void cleartext()
        {
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxStudentId.Clear();
            cboBoxDepartment.SelectedIndex = 0;
        }
    }
}
