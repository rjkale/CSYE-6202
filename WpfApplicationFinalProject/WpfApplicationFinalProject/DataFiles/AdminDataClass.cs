using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationFinalProject.DataFiles
{
    class AdminDataClass
    {

        DBconnection objcon = new DBconnection();

        public Boolean addToLoginTable(string username, string password, string companyName)
        {
            try
            {
                string role = "fc";
                objcon.Connections();
                string query = "Insert into LoginTable values(@username,@password,@name,@role)";
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

           
    }
}
