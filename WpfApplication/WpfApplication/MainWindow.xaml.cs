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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\Source\Repos\CSYE-6202_New\WindowsFormsApplication\WindowsFormsApplication\Database.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From Login where Username ='" + txtBoxUserName.Text + "' and Password = '" + passwordBox.Password + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            int count = 0;

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                HomePageWindow hp = new HomePageWindow();
                hp.Show();
            }

            else
            {
                count = count++;

                if (count == 3)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password");
                    txtBoxUserName.Clear();
                    passwordBox.Clear();

                }

            }
        }
    }
}
