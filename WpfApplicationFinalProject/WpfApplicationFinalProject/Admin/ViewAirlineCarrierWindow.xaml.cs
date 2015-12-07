using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApplicationFinalProject
{
    /// <summary>
    /// Interaction logic for ViewAirlineCarrierWindow.xaml
    /// </summary>
    public partial class ViewAirlineCarrierWindow : Window
    {
        Person p;
        public ViewAirlineCarrierWindow(Person p)
        {
            InitializeComponent();
            LoadDataGridview();
            this.p = p;
        }

        private void LoadDataGridview()
        {
            AdminDataClass admin = new AdminDataClass();
            //DataTable dt = admin.loadDataGridView1();
            //dataGrid.ItemsSource = dt.DefaultView;

            dataGrid.ItemsSource =  admin.loadDataGridView();

            /*
            List<FlightCarrier> Fc =  admin.loadDataGridView();
            if (Fc != null)
            { 
                foreach (var item in Fc)
                {
                    dataGrid.ItemsSource = item.Name;
                }
            }
            else
            {
                MessageBox.Show("List is returning null"+Fc);
            } 
            */
        }


        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            AdminHomePageWindow admin = new AdminHomePageWindow(p);
            admin.Show();
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {


            /*
            if (dataGrid.SelectedItems.Count > 0)
            {
                var UserName = ((DataRowView)dataGrid.SelectedItem).Row["userName"].ToString();
                var UserId =   ((DataRowView)dataGrid.SelectedItem).Row["Name"].ToString();
                MessageBox.Show("UserName = "+UserName + "UserId " +UserId);
            }
            */
                        
            FlightCarrier fc = (FlightCarrier)dataGrid.SelectedValue;
            var UserName1 = fc.CompanyName.ToString();
            var userId1 = fc.username.ToString();
            MessageBox.Show("UserName "+UserName1 + " UserID " +userId1);
        }
    }
}
