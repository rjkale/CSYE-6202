using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationFinalProject.Class
{
    class PaymentDetails
    {
        string CustomerUserName { set; get; }
        int cardNumber { set; get; }
        int expiryMonth { set; get; }
        int expiryYear { set; get; }
        string name { set; get; }
        int cardCVV { set; get; }
    }
}
