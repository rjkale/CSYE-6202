﻿using System;
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
    /// Interaction logic for ViewAirlineCarrierWindow.xaml
    /// </summary>
    public partial class ViewAirlineCarrierWindow : Window
    {
        public ViewAirlineCarrierWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            AdminHomePageWindow admin = new AdminHomePageWindow();
            admin.Show();
        }
    }
}
