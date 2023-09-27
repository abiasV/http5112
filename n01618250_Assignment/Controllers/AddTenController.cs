using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01618250_Assignment.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// plus ten for every integer id
        /// <example> Get api/AddTen/21 -> 31 </example>
        /// <example> Get api/AddTen/10 -> 20 </example>
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>Add ten of the integer</returns>

        public int Get(int id)
        {
            int sum = id + 10;
            return sum;
        }
    }
}
