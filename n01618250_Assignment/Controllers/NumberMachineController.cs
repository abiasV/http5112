using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01618250_Assignment.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// It returns the desired value depending on the input number
        /// <example>
        /// Get api/numbermachine/10 -> 100
        /// Get api/numbermachine/-5 -> -10
        /// Get api/numbermachine/30 -> 1
        /// </example>
        /// </summary>
        /// <param name="id">The Input Number</param>
        /// <returns>mathematical operations</returns>
        public int Get(int id)
        {
            int multiple = id * id;
            int plus = id + id;
            int divide = id / id;
            int sub = id - id;

            if ( id == 10)
            {
                return multiple;

            }else if ( id == -5 )
            {
                return plus;

            }else if ( id == 30 )
            {
                return divide;

            }else
            {
                return sub;

            }
        }
    }
}
