using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplicationFinalProject.Class;

namespace WpfApplicationFinalProject.DataFiles
{
    class AdminDataClass
    {
        DBconnection objcon = new DBconnection();
        public Boolean addToLoginTable(FlightCarrier fc)
        {
            try
            {
                string username = fc.username;
                string password = fc.password;
                string companyName = fc.CompanyName;
                string role = "fc";

                objcon.Connections();
                string query = "Insert into LoginTable values(@username,@password,@role,@name)";
                SqlCommand cmd = new SqlCommand(query, objcon.con);

                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@password", password));
                cmd.Parameters.Add(new SqlParameter("@name", companyName));
                cmd.Parameters.Add(new SqlParameter("@role", role));
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            
        }

        
        public List<FlightCarrier> loadDataGridView()
        {

            List<FlightCarrier> fclist = new List<FlightCarrier>(); 
            try
            {
                objcon.Connections();
                string query = "Select userName, Name from LoginTable where Role = 'fc' ";
                using(SqlCommand cmd = new SqlCommand(query, objcon.con))
                using (SqlDataReader reader = cmd.ExecuteReader())

                       
                      while (reader.Read())
                       {                        
                            FlightCarrier fc = new FlightCarrier();
                            fc.CompanyName = reader.GetString(1).Trim();
                            fc.username = reader.GetString(0).Trim();
                            fclist.Add(fc);
                        }
                return fclist;
            }
            catch (Exception ex)
            {
                Console.WriteLine("AdminDataClassExcepetion",ex);
                return null;
            }
        }
        
        
    
        public DataTable loadDataGridView1()
        {
            List<FlightCarrier> fclist = new List<FlightCarrier>();
            DataTable dt = new DataTable(); 
            try
            {
                objcon.Connections();
                string query = "Select userName, Name from LoginTable where Role = 'fc' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, objcon.con);
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("AdminDataClassExcepetion", ex);
            }
            return dt;
        }

    
    }
}
