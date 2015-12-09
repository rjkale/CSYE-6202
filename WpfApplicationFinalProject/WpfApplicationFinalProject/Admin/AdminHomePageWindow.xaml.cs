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
using System.Windows.Shapes;
using WpfApplicationFinalProject.Admin;
using WpfApplicationFinalProject.Class;
using WpfApplicationFinalProject.DataFiles;

namespace WpfApplicationFinalProject
{
    /// <summary>
    /// Interaction logic for AdminHomePageWindow.xaml
    /// </summary>
    public partial class AdminHomePageWindow : Window
    {
        Person p;
        FlightCarrier fc;
        string UserName1;
        string userId1;

        public AdminHomePageWindow(Person p)
        {
            InitializeComponent();
            LoadDataGridview();
            this.p = p;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddAirlineCarrierWindow addairline = new AddAirlineCarrierWindow(p);
            addairline.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {

            if (dataGrid.SelectedItems.Count > 0)
            {
                FlightCarrier fc = (FlightCarrier)dataGrid.SelectedValue;
                this.Close();
                ViewAirlineCarrierWindow vair = new ViewAirlineCarrierWindow(fc);
                vair.Show();
            }
            else
            {
                MessageBox.Show("Please select a field");
            }
        }


        private void LoadDataGridview()
        {
            AdminDataClass admin = new AdminDataClass();
            dataGrid.ItemsSource = admin.loadDataGridView();
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fc = (FlightCarrier)dataGrid.SelectedValue;
            UserName1 = fc.CompanyName.ToString();
            userId1 = fc.username.ToString();
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)

        {

            if (dataGrid.SelectedItems.Count > 0)
            {
                FlightCarrier fc = (FlightCarrier)dataGrid.SelectedValue;
                this.Close();
                AdminViewAirlinesByCarrierWindow car = new AdminViewAirlinesByCarrierWindow(fc);
                car.Show();
            }
            else
            {
                MessageBox.Show("Please select a field");
            }

            
        }
    }
}
