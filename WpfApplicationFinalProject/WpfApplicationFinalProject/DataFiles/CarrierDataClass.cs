using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplicationFinalProject.Class;

namespace WpfApplicationFinalProject.DataFiles
{
    class CarrierDataClass
    {
        DBconnection objcon = new DBconnection();
        public Boolean addToCarrierTable(Flight flight)
        {
            try
            {
                string flightName = flight.flightName;
                string flightnumber = flight.flightnumber;
                string sourceCity = flight.sourceCity;
                string destinationCity = flight.destinationCity;
                string date = flight.date;
                string duration = flight.duration;
                string fare = flight.fare;
                string ClassType = flight.ClassType;
                string NumberofSeats = flight.NumberofSeats;
                string userName = flight.userName;
                string businessPrice = flight.businessPrice;
                string economyPlus = flight.economyPlusPrice;

                objcon.Connections();
                string query = "Insert into FlightDetailsTable values(@flightName,@flightNumber,@sourceCity,@destinationCity,@date, @flightDuration,@fare,@class,@numberOfSeats,@userName,@businessPrice,@economyPlus)";
                SqlCommand cmd = new SqlCommand(query, objcon.con);
                cmd.Parameters.Add(new SqlParameter("@flightName", flightName));
                cmd.Parameters.Add(new SqlParameter("@flightNumber", flightnumber));
                cmd.Parameters.Add(new SqlParameter("@sourceCity", sourceCity));
                cmd.Parameters.Add(new SqlParameter("@destinationCity", destinationCity));
                cmd.Parameters.Add(new SqlParameter("@date", date));
                cmd.Parameters.Add(new SqlParameter("@flightDuration", duration));
                cmd.Parameters.Add(new SqlParameter("@fare", fare));
                cmd.Parameters.Add(new SqlParameter("@class", ClassType));
                cmd.Parameters.Add(new SqlParameter("@numberOfSeats", NumberofSeats));
                cmd.Parameters.Add(new SqlParameter("@userName", userName));
                cmd.Parameters.Add(new SqlParameter("@businessPrice", businessPrice));
                cmd.Parameters.Add(new SqlParameter("@economyPlus", economyPlus));
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (SqlException ex)
            {
                return false;
            }

 
        
        }
    }
}
