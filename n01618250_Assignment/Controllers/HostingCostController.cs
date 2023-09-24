using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace n01618250_Assignment.Controllers
{
    public class HostingCostController : ApiController
    {
        public string Get(int id)
        {
            int FortNight = 14;
            decimal tax = 13;
            decimal FN = 5.50m;

            if ( id >= 0 & id < FortNight ) 
            {
                int n = 1;
                string stringResult = ((FN * n) * (tax / 100)).ToString("F2");
                decimal total = ((FN * n) + Convert.ToDecimal(stringResult));
                return "1 fortnights at $5.50/FN = $" + FN + " CAD\n HST 13% = $" + stringResult + " CAD\n Total = $" + ( total ) + " CAD".Replace("\n", Environment.NewLine); ;

            }
            else if ( id >= FortNight & id < ( FortNight*2 ) ) {

                int n = 2;
                string stringResult = ((FN * n) * (tax / 100)).ToString("F2");
                decimal total = ((FN * n) + Convert.ToDecimal(stringResult));
                return "2 fortnights at $5.50/FN = $" + (FN * n) + " CAD\r\n HST 13% = $" + Convert.ToDecimal(stringResult) + " CAD\r\n Total = $" + total + " CAD";

            } else
            {
                int n = 3;
                string stringResult = ((FN * n) * (tax / 100)).ToString("F2");
                decimal total = ((FN * n) + Convert.ToDecimal(stringResult));
                return "3 fortnights at $5.50/FN = $" + (FN * n) + " CAD\r\n HST 13% = $" + Convert.ToDecimal(stringResult) + " CAD\r\n Total = $" + total + " CAD";

            }
        }
    }
}
