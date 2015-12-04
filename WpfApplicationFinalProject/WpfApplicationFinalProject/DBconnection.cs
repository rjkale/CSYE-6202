using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WpfApplicationFinalProject
{
    class DBconnection
    {
        public SqlConnection con;
        public String connectionValues;

        public void Connections()
        {
            connectionValues = @"Data Source=RAUL\MSSQLRAHUL;Initial Catalog=AirLineReservationSystem;Integrated Security=True";
            con = new SqlConnection(connectionValues);
            con.Open();
        }
    }
}
