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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\Source\Repos\CSYE-6202_New\WindowsFormsApplication\WindowsFormsApplication\Database.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From Login where Username ='" + txtBoxUserName.Text + "' and Password = '" + txtBoxPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            int count = 0;

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                HomePageForm hp = new HomePageForm();
                hp.Show();
            }

            else
            {
                count = count++;

                if (count == 3)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password");
                    txtBoxUserName.Clear();
                    txtBoxPassword.Clear();

                }

            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}