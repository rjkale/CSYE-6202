using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationFinalProject.DataFiles
{
    class CarrierDataClass
    {
        DBconnection objcon = new DBconnection();
        public Boolean addToCarrierTable(string flightName, string flightnumber, string sourceCity, string destinationCity, string date, string duration, string fare, string ClassType, string NumberofSeats, string userName)
        {
            try
            {
                objcon.Connections();
                string query = "Insert into FlightDetailsTable values(@flightName,@flightNumber,@sourceCity,@destinationCity,@date, @flightDuration,@fare,@class,@numberOfSeats,@userName)";
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
