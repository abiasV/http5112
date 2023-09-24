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
        // Get api/Square/{id}
        public int Get(int id)
        {
            int sum = id * id;
            return sum;
        }
    }
}
