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
    public partial class HomePageForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\Source\Repos\CSYE-6202_New\WindowsFormsApplication\WindowsFormsApplication\Database.mdf;Integrated Security=True");

        String FName;
        String LName;
        String SId;
        String Dept;
        String EnrolType;

        public HomePageForm()
        {
            InitializeComponent();
            DataGridView();
            dataGridView1.Refresh();
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewStudentForm ns = new NewStudentForm();
            ns.Show();
        }

        private void DataGridView()
        {
            SqlCommand cmd = new SqlCommand("SELECT * from Student",con);

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);

            BindingSource bsource = new BindingSource();
            bsource.DataSource = dt;
            dataGridView1.DataSource = bsource;
            sda.Update(dt);
        }

       

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count> 0)
            {
                SId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                FName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                LName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Dept = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                EnrolType = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                txtBoxStudentId.Text = SId;
                txtBoxFirstName.Text = FName;
                txtBoxLastName.Text = LName;
                cboBoxDepartMent.Text = Dept;
                                
                if ("Full-Time" == EnrolType)
                {
                    radioBtnFullTime.Checked = true;
                }
                else if ("Part-Time"== EnrolType)
                {
                    radioBtnPartTime.Checked = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveStudentForm rm = new RemoveStudentForm( SId,  FName,  LName,  Dept, EnrolType);
            rm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateStudentForm es = new UpdateStudentForm(SId, FName, LName, Dept, EnrolType);
            es.Show();
        }
    }
}
