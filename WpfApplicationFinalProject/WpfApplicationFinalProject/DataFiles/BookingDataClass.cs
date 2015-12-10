using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplicationFinalProject.Class;

namespace WpfApplicationFinalProject.DataFiles
{
    class BookingDataClass
    {
        Booking booking;
        DBconnection objcon = new DBconnection();

        public Boolean addtoBookings(Booking booking)
        {
            this.booking = booking;
            string customerName = booking.customerName;
            string customerUserName = booking.customerUserName;
            string customerPhone = booking.customerPhone;
            string flightCarrierUserName = booking.flightCarrierUserName;
            string flightName = booking.flightName;
            string flightnumber = booking.flightnumber;
            string sourceCity = booking.sourceCity;
            string destinationCity = booking.destinationCity;
            string date = booking.date;
            string duration = booking.duration;
            string seats = booking.seats;
            string classType = booking.classType;
            string fair = booking.fair;
            string tax = booking.tax;
            string totalAmount = booking.totalAmount;
            string departureTime = "Departure Time";
            string arrivalTime = "Arrival Time";

            //try
            //{
            objcon.Connections();
            string query = "Insert into Bookings values(@customerName,@customerUserName,@customerPhone,@flightCarrierUserName,@flightName,@flightnumber,@sourceCity, @destinationCity,@date,@duration,@seats,@classType,@fair, @tax, @totalAmount,@departureTime, @arrivalTime )";
            SqlCommand cmd = new SqlCommand(query, objcon.con);

            cmd.Parameters.Add(new SqlParameter("@customerName", customerName));
            cmd.Parameters.Add(new SqlParameter("@customerUserName", customerUserName));
            cmd.Parameters.Add(new SqlParameter("@customerPhone", customerPhone));
            cmd.Parameters.Add(new SqlParameter("@flightCarrierUserName", flightCarrierUserName));
            cmd.Parameters.Add(new SqlParameter("@flightName", flightName));
            cmd.Parameters.Add(new SqlParameter("@flightnumber", flightnumber));
            cmd.Parameters.Add(new SqlParameter("@sourceCity", sourceCity));
            cmd.Parameters.Add(new SqlParameter("@destinationCity", destinationCity));
            cmd.Parameters.Add(new SqlParameter("@date", date));
            cmd.Parameters.Add(new SqlParameter("@duration", duration));
            cmd.Parameters.Add(new SqlParameter("@seats", seats));
            cmd.Parameters.Add(new SqlParameter("@classType", classType));
            cmd.Parameters.Add(new SqlParameter("@fair", fair));
            cmd.Parameters.Add(new SqlParameter("@tax", tax));
            cmd.Parameters.Add(new SqlParameter("@totalAmount", totalAmount));
            cmd.Parameters.Add(new SqlParameter("@departureTime", departureTime));
            cmd.Parameters.Add(new SqlParameter("@arrivalTime", arrivalTime));
            cmd.ExecuteNonQuery();
            return true;
            //}
            //catch
            //{
            //    return false;
            //}

        }



    }
}
