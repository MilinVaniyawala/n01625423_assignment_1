using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace n01625423_assignment_1.Controllers
{
    public class AddTenController : ApiController
    {
        // GET: AddTen

        // Example1 - Returns 10 more than the integer input {id}.

        // GET api/AddTen/21 -> 31
        // GET api/AddTen/0 -> 10
        // GET api/AddTen/-9 -> 1

        public int Get(int id)
        {
            int temp = id + 10; // Addition Operation
            return temp; // API Returns Final Output
        }
    }
}