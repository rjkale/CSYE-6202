using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Interaction logic for CustomerSummaryPageWindow.xaml
    /// </summary>
    public partial class CustomerSummaryPageWindow : Window
    {
        Flight flight;
        Search search;
        Booking booking;
        public CustomerSummaryPageWindow(Flight flight, Search search, Booking booking)
        {
            InitializeComponent();
            this.flight = flight;
            this.search = search;
            this.booking = booking;
            updateTables();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void updateTables()
        {
            BookingDataClass book = new BookingDataClass();
            if (book.updateFlightsTable(flight, getFinalSeatsCount(),getClassTypeSeats()))
            {
                //MessageBox.Show("Flight Tabel updated");
                Console.WriteLine("Flight Tabel updated");
            }
            else
            {
                MessageBox.Show("Error updating flight tabel");
            }
            
        }



        private string getFinalSeatsCount()
        {
            string seats = booking.seats;
            string classtype = booking.classType;
            int seat = Convert.ToInt32(seats);
            int flightSeats = 0;

            if (classtype == "Economy")
            {
                flightSeats = flight.EconomySeats;
            }
            else if (classtype == "Economy Plus")
            {
                flightSeats = flight.EconomyPlusSeats;
            }
            else if (classtype == "Business")
            {
                flightSeats = flight.BusinessSeats;
            }

            
            int SeatCount = flightSeats - seat;
            return Convert.ToString(SeatCount);
        }


        private string getClassTypeSeats()
        {
            string classtype = booking.classType;

            if (classtype == "Economy")
            {
                return "EconomySeats";
            }
            else if (classtype == "Economy Plus")
            {
                return "EconomyPlusSeats";
            }
            else
                return "BusinessSeats";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            
           
            string CustomerName =  booking.customerName;
            string CustomerPhone =  booking.customerPhone;
            string FlightName = booking.flightName;
            string FlightNumber = booking.flightnumber;
            string SourceCity = booking.sourceCity;
            string DestinationCity = booking.destinationCity;
            string BookingDate = booking.date;
            string FlightDuration = booking.duration;
            string Seat = booking.seats;
            string ClassType = booking.classType;
            string Fair = booking.fair;
            string tax = booking.tax;
            string TotalAmount = booking.totalAmount;
            string Time = booking.timStamp;


            string date = booking.timStamp;
            string filename = booking.customerName + booking.flightnumber+".pdf";
            string content = "TICKET\n\n CustomerName = " + CustomerName+ "\n CustomerPhone = "+ CustomerPhone + "\n FlightName = "
                            + FlightName + "\n FlightNumber = " + FlightNumber + "\n SourceCity = " + SourceCity+ "\n DestinationCity = "
                            + DestinationCity+ "\n BookingDate = " + "\n FlightDuration = " + FlightDuration+
                            "\n Seat = " + Seat+ "\n ClassType = " + ClassType + "\n Fair " + Fair+ "\n tax = " + tax + "\n TotalAmount " + TotalAmount+ "\n Time " + Time;

            /*
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "PDF"+filename;
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 30, XFontStyle.Bold);
            graph.DrawString(content, font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            string pdfFilename = @"G:\C sharp\Final Project\pdfs\" + filename;
            pdf.Save(pdfFilename);
            Process.Start(pdfFilename);
            */

            PdfDocument document = new PdfDocument();

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Times New Roman", 20, XFontStyle.Bold);
            XTextFormatter tf = new XTextFormatter(gfx);

            XRect rect = new XRect(40, 40, 400, 400);
            gfx.DrawRectangle(XBrushes.Silver, rect);
            tf.DrawString(content, font, XBrushes.Black, rect, XStringFormats.TopLeft);
            string pdfFilename = @"G:\C sharp\Final Project\pdfs\" + filename;
            document.Save(pdfFilename);
            Process.Start(pdfFilename);

        }

        /*
        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        */




    }
}
