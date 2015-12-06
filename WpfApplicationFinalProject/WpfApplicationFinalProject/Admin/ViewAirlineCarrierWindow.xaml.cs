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
        public ViewAirlineCarrierWindow()
        {
            InitializeComponent();
            LoadDataGridview();
        }

        private void LoadDataGridview()
        {
            AdminDataClass admin = new AdminDataClass();
            DataTable dt = admin.loadDataGridView1();
            dataGrid.ItemsSource = dt.DefaultView;

            //dataGrid.ItemsSource =  admin.loadDataGridView();

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
            AdminHomePageWindow admin = new AdminHomePageWindow();
            admin.Show();
        }
    }
}
