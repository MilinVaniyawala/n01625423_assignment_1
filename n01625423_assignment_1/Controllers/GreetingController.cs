using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01625423_assignment_1.Controllers
{
    public class GreetingController : ApiController
    {
        // POST: Greeting

        /// <summary>
        /// Example3 - Returns the string “Hello World!”
        /// </summary
        /// <returns>
        /// POST api/Greeting -> "Hello World!"
        /// output in command prompt screenshot -> https://prnt.sc/8G53bUKTZKIB
        /// </returns>

        public string Post()
        { 
            return "Hello World!"; // API Returns Final Output in String "Hello World!"
        }


        // GET: Greeting

        /// <summary>
        /// Example4 - Returns the string “Greetings to {id} people!” where id is an integer value.
        /// </summary>
        /// <param name="id"> Here we passed number as input for example: 3,6,0</param>
        /// <returns>
        /// GET api/Greeting/3 -> Greetings to 3 people
        /// GET api/Greeting/6 -> Greetings to 6 people
        /// GET api/Greeting/0 -> Greetings to 0 people
        /// </returns>

        public string Get(int id)
        {
            string greetingMessage = "Greetings to " + id + " people!";
            return greetingMessage; // API Returns Final Output as Greetings to {id} people!"
        }
    }
}
