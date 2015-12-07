using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplicationFinalProject.Class;

namespace WpfApplicationFinalProject.DataFiles
{
    
    class SignUpDataClass
    {
        DBconnection objcon = new DBconnection();

        public Boolean signupCustomer(Person p)
        {
            string username =  p.username;
            string password = p.password;
            string name = p.name;
            string city = p.city;
            string phone = p.phone;
            string gender = p.gender;
            string age = p.age;

            try
            {
            objcon.Connections();

            string query = "Insert into CustomerDatabaseTable values(@username,@password,@name, @city, @phone, @gender, @age)";
            SqlCommand cmd = new SqlCommand(query, objcon.con);
            //SqlDataReader reader = cmd.ExecuteReader();
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@name", name));
            cmd.Parameters.Add(new SqlParameter("@city", city));
            cmd.Parameters.Add(new SqlParameter("@phone", phone));
            cmd.Parameters.Add(new SqlParameter("@gender", gender));
            cmd.Parameters.Add(new SqlParameter("@age", age));
            cmd.ExecuteNonQuery();

            return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception in Signup" + ex);
                return false;
            }
            
        }

        public Boolean addToUserLoginTable(Person person)
        {

            string username = person.username;
            string password = person.password;
            string name = person.name;

            try
            {
                objcon.Connections();
                string role = "cus";

                string query = "Insert into LoginTable values(@username,@password,@role,@name)";
                SqlCommand cmd = new SqlCommand(query, objcon.con);

                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@password", password));
                cmd.Parameters.Add(new SqlParameter("@name", name));
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
