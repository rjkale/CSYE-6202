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
            //try
            //{
                               
                string userName = flight.userName;
                string flightName = flight.flightName;
                string flightnumber = flight.flightnumber;
                string sourceCity = flight.sourceCity;
                string destinationCity = flight.destinationCity;
                string date = flight.date;
                string duration = flight.duration;
                string EconomyPrice = flight.EconomyPrice;
                string economyPlusPrice = flight.economyPlusPrice;
                string BusinessPrice = flight.businessPrice;
                string EconomySeats = flight.EconomySeats;
                string EconomyPlusSeats = flight.EconomyPlusSeats;
                string BusinessSeats = flight.BusinessSeats;
                

                objcon.Connections();
                string query = "Insert into FlightDetailsTable values(@userName,@flightName,@flightnumber,@sourceCity,@destinationCity, @travelDate, @flightDuration,@ecnomyFair,@EconomyPlusFair,@BusinessFair,@EconomySeats, @EconomyPlusSeats, @BusinessSeats)";
                SqlCommand cmd = new SqlCommand(query, objcon.con);
                cmd.Parameters.Add(new SqlParameter("@userName", userName));
                cmd.Parameters.Add(new SqlParameter("@flightName", flightName));
                cmd.Parameters.Add(new SqlParameter("@flightNumber", flightnumber));
                cmd.Parameters.Add(new SqlParameter("@sourceCity", sourceCity));
                cmd.Parameters.Add(new SqlParameter("@destinationCity", destinationCity));
                cmd.Parameters.Add(new SqlParameter("@travelDate", date));
                cmd.Parameters.Add(new SqlParameter("@flightDuration", duration));
                cmd.Parameters.Add(new SqlParameter("@ecnomyFair", EconomyPrice));
                cmd.Parameters.Add(new SqlParameter("@EconomyPlusFair", economyPlusPrice));
                cmd.Parameters.Add(new SqlParameter("@BusinessFair", BusinessPrice));
                cmd.Parameters.Add(new SqlParameter("@EconomySeats", EconomySeats));
                cmd.Parameters.Add(new SqlParameter("@EconomyPlusSeats", EconomyPlusSeats));
                cmd.Parameters.Add(new SqlParameter("@BusinessSeats", BusinessSeats));
                cmd.ExecuteNonQuery();
                return true;
            //}

            //catch (SqlException ex)
            //{
            //    return false;
            //}
        }


        public List<Flight> loadDataGridView(FlightCarrier flight)
        {
            String userName = flight.username;
           // Console.WriteLine("UserName" + userName);
            List<Flight> flist = new List<Flight>();
           // try
          //  {
                objcon.Connections();
                string query = "Select * from FlightDetailsTable where  userName = '"+userName+"' ";
                using (SqlCommand cmd = new SqlCommand(query, objcon.con))
                using (SqlDataReader reader = cmd.ExecuteReader())

                    while (reader.Read())
                    {
                        Flight f = new Flight();
                        f.userName = reader.GetString(0).Trim();
                        f.flightName = reader.GetString(1).Trim();
                        f.flightnumber = reader.GetString(2).Trim();
                        f.sourceCity = reader.GetString(3).Trim();
                        f.destinationCity = reader.GetString(4).Trim();
                        f.date = reader.GetString(5).Trim();
                        f.duration = reader.GetString(6).Trim();
                        f.EconomyPrice = reader.GetString(7).Trim();
                        f.economyPlusPrice = reader.GetString(8).Trim();
                        f.businessPrice = reader.GetString(9).Trim();
                        f.EconomySeats = reader.GetString(10).Trim();
                        f.EconomyPlusSeats = reader.GetString(11).Trim();
                        f.BusinessSeats = reader.GetString(12).Trim();
                        flist.Add(f);                   
                    }
                        return flist;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("CarrierException", ex);
            //    return null;
            //}
            //return flist;
        }



        public Boolean removeCarrier(Flight flight)
        {
            //try
            //{

            string flightName = flight.flightName;
            
            objcon.Connections();
            string query = "Delete from FlightDetailsTable where flightName = @flightName";
            SqlCommand cmd = new SqlCommand(query, objcon.con);
            cmd.Parameters.Add(new SqlParameter("@flightName", flightName));
            cmd.ExecuteNonQuery();
            return true;
            //}

            //catch (SqlException ex)
            //{
            //    return false;
            //}
        }



        public Boolean updateCarrierTable(Flight flight)
        {
            try
            {

            string userName = flight.userName;
            string flightName = flight.flightName;
            string flightnumber = flight.flightnumber;
            string sourceCity = flight.sourceCity;
            string destinationCity = flight.destinationCity;
            string date = flight.date;
            string duration = flight.duration;
            string EconomyPrice = flight.EconomyPrice;
            string economyPlusPrice = flight.geteconomyPlusPrice(EconomyPrice);
            string BusinessPrice = flight.getBusinessPrice(EconomyPrice);
            string EconomySeats = flight.EconomySeats;
            string EconomyPlusSeats = flight.EconomyPlusSeats;
            string BusinessSeats = flight.BusinessSeats;


            objcon.Connections();
            string query = "Update FlightDetailsTable set flightName = @flightName, sourceCity = @sourceCity , destinationCity = @destinationCity, flightDuration = @flightDuration, ecnomyFair = @ecnomyFair, EconomyPlusFair = @EconomyPlusFair, BusinessFair = @BusinessFair, EconomySeats = @EconomySeats, EconomyPlusSeats = @EconomyPlusSeats, BusinessSeats = @BusinessSeats where flightnumber = '" + flightnumber.Trim() + "' ";
            SqlCommand cmd = new SqlCommand(query, objcon.con);
           //cmd.Parameters.Add(new SqlParameter("@userName", userName));
            cmd.Parameters.Add(new SqlParameter("@flightName", flightName));
            cmd.Parameters.Add(new SqlParameter("@flightNumber", flightnumber));
            cmd.Parameters.Add(new SqlParameter("@sourceCity", sourceCity));
            cmd.Parameters.Add(new SqlParameter("@destinationCity", destinationCity));
            cmd.Parameters.Add(new SqlParameter("@travelDate", date));
            cmd.Parameters.Add(new SqlParameter("@flightDuration", duration));
            cmd.Parameters.Add(new SqlParameter("@ecnomyFair", EconomyPrice));
            cmd.Parameters.Add(new SqlParameter("@EconomyPlusFair", economyPlusPrice));
            cmd.Parameters.Add(new SqlParameter("@BusinessFair", BusinessPrice));
            cmd.Parameters.Add(new SqlParameter("@EconomySeats", EconomySeats));
            cmd.Parameters.Add(new SqlParameter("@EconomyPlusSeats", EconomyPlusSeats));
            cmd.Parameters.Add(new SqlParameter("@BusinessSeats", BusinessSeats));
            cmd.ExecuteNonQuery();
            return true;

            // flightDuration = @flightDuration, ecnomyFair = @ecnomyFair, EconomyPlusFair = @EconomyPlusFair, BusinessFair = @BusinessFair, EconomySeats = @EconomySeats, EconomyPlusSeats = @EconomyPlusSeats, BusinessSeats = @BusinessSeats
            }

            catch (SqlException ex)
            {
                Console.WriteLine("Inside Update exception");
                return false;
            }
        }


    }
}
