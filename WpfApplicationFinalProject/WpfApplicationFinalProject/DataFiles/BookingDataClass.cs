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
        Flight flight;
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
            string timeStamp = booking.timStamp;

            //try
            //{
            objcon.Connections();
            string query = "Insert into Bookings values(@customerName,@customerUserName,@customerPhone,@flightCarrierUserName,@flightName,@flightnumber,@sourceCity, @destinationCity,@date,@duration,@seats,@classType,@fair, @tax, @totalAmount,@departureTime, @arrivalTime,@timeStamp )";
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
            cmd.Parameters.Add(new SqlParameter("@timeStamp", timeStamp));
            cmd.ExecuteNonQuery();
            return true;
            //}
            //catch
            //{
            //    return false;
            //}

        }


        public Boolean updateFlightsTable(Flight flight, string seat, string classTypeSeats)
        {
            string flightCarrierUserName = flight.userName;
            string flightName = flight.flightName;
            string flightnumber = flight.flightnumber;
            int seats = Convert.ToInt32(seat);
            string classtypeSeats = classTypeSeats;
            

            //try
            //{
            objcon.Connections();
            string query = "update FlightDetailsTable set "+ classtypeSeats + " = @seats where userName = @flightCarrierUserName and flightNumber = @flightnumber and flightName = @flightName ";
            SqlCommand cmd = new SqlCommand(query, objcon.con);

            cmd.Parameters.Add(new SqlParameter("@flightCarrierUserName", flightCarrierUserName));
            cmd.Parameters.Add(new SqlParameter("@flightName", flightName));
            cmd.Parameters.Add(new SqlParameter("@flightnumber", flightnumber));
            cmd.Parameters.Add(new SqlParameter("@seats", seats));
            cmd.Parameters.Add(new SqlParameter("@classtypeSeats", classtypeSeats));
            
            cmd.ExecuteNonQuery();
            return true;
            //}
            //catch
            //{
            //    return false;
            //}
        }



        public List<Booking> loadBookedFlightsDataGridView(Person person)
        {

            
            String userName = person.username;

            List<Booking> book = new List<Booking>();

            // try
            //  {

            objcon.Connections();
            string query = "Select * from Bookings where  customerUserName = '" + userName + "' ";
            using (SqlCommand cmd = new SqlCommand(query, objcon.con))
            using (SqlDataReader reader = cmd.ExecuteReader())

                while (reader.Read())
                {
                    Booking b = new Booking();
                    b.customerUserName = reader.GetString(0).Trim();
                    b.customerName = reader.GetString(1).Trim();
                    b.customerPhone = reader.GetString(2).Trim();
                    b.flightCarrierUserName = reader.GetString(3).Trim();
                    b.flightName = reader.GetString(4).Trim();
                    b.flightnumber = reader.GetString(5).Trim();
                    b.sourceCity = reader.GetString(6).Trim();
                    b.destinationCity = reader.GetString(7).Trim();
                    b.date = reader.GetString(8).Trim();
                    b.duration = reader.GetString(9).Trim();
                    b.seats = reader.GetString(10).Trim();
                    b.classType = reader.GetString(11).Trim();
                    b.fair = reader.GetString(12).Trim();
                    b.tax = reader.GetString(13).Trim();
                    b.totalAmount = reader.GetString(14).Trim();
                    b.timStamp = reader.GetString(17).Trim();
                    book.Add(b);
                }
            return book;
        }

        

        public Boolean unBookFlightTable(Booking booking, string classTypeSeats)
        {
            string userName = booking.customerUserName;

            string flightCarrierUserName = booking.flightCarrierUserName;
            string flightName = booking.flightName;
            string flightnumber = booking.flightnumber;
            int seats = Convert.ToInt32(booking.seats);
            string classtypeSeats = classTypeSeats;
            string timestamp = booking.timStamp;

            objcon.Connections();
            string query = "update FlightDetailsTable set " + classtypeSeats + " = " + classtypeSeats + " + @seats where flightnumber = @flightnumber";
            SqlCommand cmd = new SqlCommand(query, objcon.con);

            cmd.Parameters.Add(new SqlParameter("@flightCarrierUserName", flightCarrierUserName));
            cmd.Parameters.Add(new SqlParameter("@flightName", flightName));
            cmd.Parameters.Add(new SqlParameter("@flightnumber", flightnumber));
            cmd.Parameters.Add(new SqlParameter("@seats", seats));
            cmd.Parameters.Add(new SqlParameter("@classtypeSeats", classtypeSeats));
            cmd.Parameters.Add(new SqlParameter("@timestamp", timestamp));

            cmd.ExecuteNonQuery();
            return true;
            //}
            //catch
            //{
            //    return false;
            //}


            }


        public Boolean updateBookingsTable(Booking booking, string classTypeSeats)
        {
            string userName = booking.customerUserName;

            string flightCarrierUserName = booking.flightCarrierUserName;
            string flightName = booking.flightName;
            string flightnumber = booking.flightnumber;
            int seats = Convert.ToInt32(booking.seats);
            string classtypeSeats = classTypeSeats;
            string timestamp = booking.timStamp;

            objcon.Connections();
            string query = "Delete from Bookings where flightnumber = @flightnumber and timestamp = @timestamp";
            SqlCommand cmd = new SqlCommand(query, objcon.con);

            cmd.Parameters.Add(new SqlParameter("@flightCarrierUserName", flightCarrierUserName));
            cmd.Parameters.Add(new SqlParameter("@flightName", flightName));
            cmd.Parameters.Add(new SqlParameter("@flightnumber", flightnumber));
            cmd.Parameters.Add(new SqlParameter("@seats", seats));
            cmd.Parameters.Add(new SqlParameter("@classtypeSeats", classtypeSeats));
            cmd.Parameters.Add(new SqlParameter("@timestamp", timestamp));

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
