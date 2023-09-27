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
        /// <summary>
        /// send hello world! to output
        /// <example> Get api/Greeting </example>
        /// </summary>
        /// <param name="Greeting">String</param>
        /// <returns> Hello World! </returns>

        public IEnumerable<string> Get()
        {
            return new string[] { "Hello " + "World!" } ;
        }

        /// <summary>
        /// greeting to how many people!
        /// <example> Get api/Greeting/3 -> Greetings to 3 people! </example>
        /// <example> Get api/Greeting/6 -> Greetings to 6 people! </example>
        /// </summary>
        /// <param name="id">String</param>
        /// <returns> Greetings to {id} people!” where id is an integer value </returns>

        public string Get(int id)
        {
            return  "Greetings to " + id + " people!" ;
        }
    }


}
