using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01618250_Assignment.Controllers
{
    public class GreetingController : ApiController
    {
        // Get api/Greeting
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello " + "World!" } ;
        }

        // Get api/Greeting/{id}

        public string Get(int id)
        {
            return  "Greeting to " + id + " people!" ;
        }
    }


}
