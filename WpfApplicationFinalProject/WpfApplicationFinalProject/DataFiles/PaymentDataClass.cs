using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplicationFinalProject.Class;

namespace WpfApplicationFinalProject.DataFiles
{
    class PaymentDataClass
    {
        PaymentDetails paymentDetails;
        DBconnection objcon = new DBconnection();

        public Boolean addToPayment(PaymentDetails paymentDetails)
        {
            this.paymentDetails = paymentDetails;

            string customerUserName = paymentDetails.CustomerUserName;
            string cardNumber = paymentDetails.cardNumber;
            string expiryMonth = paymentDetails.expiryMonth;
            string expiryYear = paymentDetails.expiryYear;
            string cardName = paymentDetails.cardName;
            string cardCVV = paymentDetails.cardCVV;

            //try
            //{
                objcon.Connections();
                string query = "Insert into Payments values(@customerUserName,@cardNumber,@expiryMonth,@expiryYear,@name, @cardCVV)";
                SqlCommand cmd = new SqlCommand(query, objcon.con);

                cmd.Parameters.Add(new SqlParameter("@customerUserName", customerUserName));
                cmd.Parameters.Add(new SqlParameter("@cardNumber", cardNumber));
                cmd.Parameters.Add(new SqlParameter("@expiryMonth", expiryMonth));
                cmd.Parameters.Add(new SqlParameter("@expiryYear", expiryYear));
                cmd.Parameters.Add(new SqlParameter("@name", cardName));
                cmd.Parameters.Add(new SqlParameter("@cardCVV", cardCVV));
                cmd.ExecuteNonQuery();
                return true;
            //}
            //catch
            //{
            //    return false;
            //}

        }


    }
}
