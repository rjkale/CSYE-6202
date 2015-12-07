using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WpfApplicationFinalProject.Class;

namespace WpfApplicationFinalProject
{
    class LoginDataClass
    {
        DBconnection objcon = new DBconnection();


        public Person getUserType(User user)
        {
            objcon.Connections();

            string UserName = user.username;
            string Password = user.password;

            Person person = new Person();
            string query = "Select * from LoginTable where userName = '" + UserName + "' and password = '" + Password + "' ";
            SqlCommand cmd = new SqlCommand(query, objcon.con);
            SqlDataReader reader = cmd.ExecuteReader();


            // string query = "Select * from LoginTable where userName = '" + UserName + "' and password = '" + Password + "' ";
            // SqlDataAdapter sda = new SqlDataAdapter(query, objcon.con);
            // DataTable dt = new DataTable();
            // sda.Fill(dt);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    person.username = reader.GetString(0).Trim();
                    person.password = reader.GetString(1).Trim();
                    person.Role = reader.GetString(2).Trim();
                    return person;
                }
            }

                person.Role = "incorrect";
                return person;
        }





    }
}
