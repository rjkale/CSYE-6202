using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationFinalProject.Class
{
    class PaymentDetails
    {
        public string CustomerUserName { set; get; }
        public string cardNumber { set; get; }
        public string expiryMonth { set; get; }
        public string expiryYear { set; get; }
        public string cardName { set; get; }
        public string cardCVV { set; get; }
    }
}
