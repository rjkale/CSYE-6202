using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationFinalProject.Class
{
    class Flight
    {
        FlightCarrier fc { set; get; }
        public string userName { set; get; }
        public string flightName { set; get; }
        public string flightnumber { set; get; }
        public string sourceCity { set; get; }
        public string destinationCity { set; get; }
        public string date { set; get; }
        public string duration { set; get; }
        public string EconomyPrice { set; get; }
        public string businessPrice { set; get; }
        public string economyPlusPrice { set; get; }
        public string EconomySeats { set; get; }
        public string EconomyPlusSeats { set; get; }
        public string BusinessSeats { set; get; }
        

        public String getBusinessPrice(String economy)
        {
            int i = Convert.ToInt32(economy);
            int result = i * 4;
            return Convert.ToString(result);
        }

        public String geteconomyPlusPrice(String economy)
        {
            int i = Convert.ToInt32(economy);
            int result = i * 2;
            return Convert.ToString(result);
        }
    }
}
