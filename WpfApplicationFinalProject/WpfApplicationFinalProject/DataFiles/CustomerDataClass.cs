using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplicationFinalProject.Class;

namespace WpfApplicationFinalProject.DataFiles
{
    class CustomerDataClass
    {
        Flight flight;
        FlightCarrier fc;
        DBconnection objcon = new DBconnection();


        public Person getUserInfo(String username)
        {
            objcon.Connections();

            string userId = username;

            Person person = new Person();
            string query = "Select * from CustomerDatabaseTable where userId = '" + userId + "' ";
            SqlCommand cmd = new SqlCommand(query, objcon.con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    person.username = reader.GetString(0).Trim();
                    person.name = reader.GetString(2).Trim();
                    person.city = reader.GetString(3).Trim();
                    person.phone = reader.GetString(4).Trim();
                    person.gender = reader.GetString(5).Trim();
                    person.age = reader.GetString(6).Trim();
                    return person;
                }
            }
            
                person.username = "null";
                person.name= "null";
                return person;
        }



        public List<Booking> loadCustomerBookingsDataGridView(Flight flight, FlightCarrier fc)
        {
            String flightnumber = flight.flightnumber;
            string flightCarrierUserName = fc.username;
            List<Booking> booking = new List<Booking>();

            objcon.Connections();
            string query = "Select * from Bookings where  flightnumber = '" + flightnumber + "' and flightCarrierUserName = '"+flightCarrierUserName + "'";
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
                    booking.Add(b);
                }
            return booking;
        }


    }
}
