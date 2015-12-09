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

namespace WpfApplicationFinalProject.HomePage_and_Signup
{
    /// <summary>
    /// Interaction logic for HomePageSearchResultsWindow.xaml
    /// </summary>
    public partial class HomePageSearchResultsWindow : Window
    {
        Search search;
        public HomePageSearchResultsWindow(Search search)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.search = search;

            loadDataGrid();
        }

        private void show()
        {
            string source = search.sourceCity;
            string destination = search.destinationCity;
            string date = search.date;
            string seats = search.seats;
            MessageBox.Show(source + " " + destination + " " + date+ " " + seats);
        }


        private void loadDataGrid()
        {
            SearchDataClass s = new SearchDataClass();
            dataGrid.ItemsSource = s.loadDataGridView(search);
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
