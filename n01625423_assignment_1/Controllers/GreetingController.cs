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

        // Example3 - Returns the string “Hello World!”

        // POST api/Greeting -> "Hello World!"

        public string Post()
        { 
            return "Hello World!"; // API Returns Final Output in String "Hello World!"
        }

        // output in command prompt screenshot -> https://prnt.sc/8G53bUKTZKIB

        // GET: Greeting

        // Example4 - Returns the string “Greetings to {id} people!” where id is an integer value.

        // GET api/Greeting/3 -> Greetings to 3 people
        // GET api/Greeting/6 -> Greetings to 6 people
        // GET api/Greeting/0 -> Greetings to 0 people
        public string Get(int id)
        {
            string greetingMessage = "Greetings to " + id + " people!";
            return greetingMessage; // API Returns Final Output as Greetings to {id} people!"
        }
    }
}
