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
using WpfApplicationFinalProject.Class;
using WpfApplicationFinalProject.DataFiles;

namespace WpfApplicationFinalProject.Customer
{
    /// <summary>
    /// Interaction logic for CustomerSearchPageWindow.xaml
    /// </summary>
    public partial class CustomerSearchPageWindow : Window
    {
        Search search;
        public CustomerSearchPageWindow(Search search)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.search = search;
            loadDataGrid();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count > 0)
            {
                try
                {
                    Flight flight = (Flight)dataGrid.SelectedValue;
                    this.Close();
                    CustomerBookingPage cust = new CustomerBookingPage(flight, search);
                    cust.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("No values in the grid");
                }
            }
            else
            {
                MessageBox.Show("Please select a field");
            }
        }

        private void loadDataGrid()
        {
            SearchDataClass s = new SearchDataClass();
            List<Flight> flist = s.loadDataGridView(search);
            dataGrid.ItemsSource = flist;
        }
    }
}
