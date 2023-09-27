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

        /// <summary>
        /// Example1 - Returns 10 more than the integer input {id}.
        /// </summary>
        /// <param name="id">Here we passed number as input for example: 31,10,1</param>
        /// <returns>
        /// GET api/AddTen/21 -> 31
        /// GET api/AddTen/0 -> 10
        /// GET api/AddTen/-9 -> 1
        ///</returns>

        public int Get(int id)
        {
            int temp = id + 10; // Addition Operation
            return temp; // API Returns Final Output
        }
    }
}