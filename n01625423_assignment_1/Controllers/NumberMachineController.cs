using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01625423_assignment_1.Controllers
{
    public class NumberMachineController : ApiController
    {
        // GET: NumberMachine

        // Example5 - Create a method which has an input {id}, and applies four mathematical operations to it.

        // GET api/NumberMachine/10 -> ?
        // GET api/NumberMachine/-5 -> ?
        // GET api/NumberMachine/30 -> ?
        public string Get(int id)
        {
            int summation = 5 + id;
            int subtraction = 20 - id;
            int multiplication = id * id;
            int division = id / 2;
            string finalOutput = "Summation of 5+" + id + " is " + summation + ",Subtraction of 20-" + id + " is " + subtraction + ", Multiplication of " + id + "*" + id + " is " + multiplication + " Now division of " + id + "/2 is " + division;  
            return finalOutput; // API Returns Final Output"
        }
    }
}
