using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01625423_assignment_1.Controllers
{
    public class SquareController : ApiController
    {
        // GET: Square

        // Example2 - Returns the square of the integer input {id}.

        // GET api/Square/2 -> 4
        // GET api/Square/-2 -> 2
        // GET api/Square/10 -> 100

        public int Get(int id)
        {
            int sqrt = id*id; // Square Operation
            return sqrt; // API Returns Final Output
        }
    }
}
