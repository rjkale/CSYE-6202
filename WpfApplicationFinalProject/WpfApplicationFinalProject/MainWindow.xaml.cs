using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfApplicationFinalProject.Class;
using WpfApplicationFinalProject.HomePage_and_Signup;

namespace WpfApplicationFinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            populateCombobox();
            DatePicker.SelectedDate = new DateTime(2015, 12, 11);
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SignInWindow signIn = new SignInWindow();
            signIn.Show();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SignUp SignUp = new SignUp();
            SignUp.Show();
        }

        private void populateCombobox()
        {
            string[] str = new string[] { "NY", "Boston", "Chicago", "Rhode Island", "Houston", "Austin", "Seattle", "San Fransisco", "Washinton DC", "Los Angeles", "Philadelphia", "Portland", "Atlanta" };

            foreach (var item in str)
            {
                coBoxSourceCity.Items.Add(item);
                coBoxDestinationCity.Items.Add(item);

            }
            coBoxSourceCity.SelectedIndex = 1;
            coBoxDestinationCity.SelectedIndex = 2;


            string[] classs = new string[] {"Economy", "Economy Plus" , "Business"};

            foreach (var item in classs)
            {
                coboxClass.Items.Add(item);
            }
            coboxClass.SelectedIndex = 0;

            for (int i = 1; i < 10; i++)
            {
                coboxSeats.Items.Add(i);
            }coboxSeats.SelectedIndex = 0;

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (checkforvalues() == true)
            {
                Search search = new Search();
                search.sourceCity = coBoxSourceCity.SelectedValue.ToString();
                search.destinationCity = coBoxDestinationCity.SelectedValue.ToString();
                search.classType = coboxClass.SelectedValue.ToString();
                search.date = DatePicker.SelectedDate.Value.ToShortDateString();
                search.seats = coboxSeats.SelectedValue.ToString();

                
                HomePageSearchResultsWindow s = new HomePageSearchResultsWindow(search);
                s.Show(); 
                
            }
            else
            {
                MessageBox.Show("Please select different Source and Destination cities \n OR \nSelect a date");
            }
        }

        private Boolean checkforvalues()
        {
            string source = coBoxSourceCity.SelectedValue.ToString();
            string destination = coBoxDestinationCity.SelectedValue.ToString();
            string date = DatePicker.ToString();
            if (source == destination)
            {
                return false;
            }
            else if (date == "")
            {
                return false;
            }
            

            return true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string u = coboxSeats.Text;
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "My First PDF";
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            graph.DrawString("This is my first PDF document" + u, font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
            string pdfFilename = "firstpage.pdf";
            pdf.Save(pdfFilename);
            Process.Start(pdfFilename);

        }
    }
}
