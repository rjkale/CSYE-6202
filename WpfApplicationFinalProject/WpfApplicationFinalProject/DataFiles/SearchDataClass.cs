using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplicationFinalProject.Class;

namespace WpfApplicationFinalProject.DataFiles
{
    class SearchDataClass
    {
        DBconnection objcon = new DBconnection();
        public List<Flight> loadDataGridView(Search search)
        {
            string source = search.sourceCity;
            string destination = search.destinationCity;
            string date = search.date;
            string seats = search.seats;
            string classSeats = "";
            string classType = search.classType;
            if (search.classType == "Economy")
            {
                 classSeats = "EconomySeats";
            }
            else if (search.classType == "Economy Plus")
            {
                 classSeats = "EconomyPlusSeats";
            }
            else if (search.classType == "Business")
            {
                 classSeats = "BusinessSeats";
            }

            
            
            List<Flight> flist = new List<Flight>();
            try
            {
                objcon.Connections();
            string query = "  Select * from FlightDetailsTable where  sourceCity = '"+source+"'   and destinationCity = '"+destination+"' and travelDate ='"+date+"'  and  "+ classSeats +" > '"+seats+"'  ";
            using (SqlCommand cmd = new SqlCommand(query, objcon.con))
            using (SqlDataReader reader = cmd.ExecuteReader())

                while (reader.Read())
                {
                    Flight f = new Flight();
                    
                    f.flightName = reader.GetString(1).Trim();
                    f.flightnumber = reader.GetString(2).Trim();
                    f.sourceCity = reader.GetString(3).Trim();
                    f.destinationCity = reader.GetString(4).Trim();
                    f.date = reader.GetString(5).Trim();
                    f.duration = reader.GetString(6).Trim();
                    f.EconomyPrice = reader.GetString(7).Trim();
                    f.economyPlusPrice = reader.GetString(8).Trim();
                    f.businessPrice = reader.GetString(9).Trim();
                    f.EconomySeats = reader.GetInt32(10);
                    f.EconomyPlusSeats = reader.GetInt32(11);
                    f.BusinessSeats = reader.GetInt32(12);
                    f.userName = reader.GetString(0).Trim();
                    flist.Add(f);
                }
            return flist;
        }
            catch (Exception ex)
            {
                Console.WriteLine("CarrierException", ex);
                return null;
            }

        }



        public Boolean saveSearchResults(Search search)
        {
            string source = search.sourceCity;
            string destination = search.destinationCity;
            string date = search.date;
            string seats = search.seats;
            string classtype = "";
            if (search.classType == "Economy")
            {
                classtype = "EconomySeats";
            }
            else if (search.classType == "Economy Plus")
            {
                classtype = "EconomyPlusSeats";
            }
            else if (search.classType == "Business")
            {
                classtype = "BusinessSeats";
            }

            try
            {
                objcon.Connections();
                string query = "Insert into SearchHistory values(@source,@destination,@date, @seats, @classtype)";
                SqlCommand cmd = new SqlCommand(query, objcon.con);
                cmd.Parameters.Add(new SqlParameter("@source", source));
                cmd.Parameters.Add(new SqlParameter("@destination", destination));
                cmd.Parameters.Add(new SqlParameter("@date", date));
                cmd.Parameters.Add(new SqlParameter("@seats", seats));
                cmd.Parameters.Add(new SqlParameter("@classtype", classtype));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception in Insert into Search History Table" + ex);
                return false;
            }

        }




    }

}
