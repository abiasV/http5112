using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01618250_Assignment.Controllers
{

    public class SquareController : ApiController
    {
        /// <summary>
        /// square of the integer input
        /// <example> Get api/Square/2 -> 4 </example>
        /// <example> Get api/Square/-2 -> 4 </example>
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>Returns the square of the integer input {id}.</returns>
        // 
        public int Get(int id)
        {
            int sum = id * id;
            return sum;
        }
    }
}
