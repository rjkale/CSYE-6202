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

namespace WpfApplicationFinalProject
{
    /// <summary>
    /// Interaction logic for AdminHomePageWindow.xaml
    /// </summary>
    public partial class AdminHomePageWindow : Window
    {
        public AdminHomePageWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddAirlineCarrierWindow addairline = new AddAirlineCarrierWindow();
            addairline.Show();

        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ViewAirlineCarrierWindow vair = new ViewAirlineCarrierWindow();
            vair.Show();
        }
    }
}
