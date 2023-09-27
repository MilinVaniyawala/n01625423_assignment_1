using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace n01625423_assignment_1.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET: HostingCost

        // Example 6: You are charging your client $5.50 / FN (fortnight = 14 days) for web hosting and maintenance, plus an additional 13% HST.The input { id } represents the number of days which has elapsed since the beginning of the hosting.Output 3 strings which describe the total hosting cost.

        public string[] Get(int id)
        {
            // Variables
            double defaultCostPerFN = 5.50;
            int FN = 14;
            int HSTTax = 13;
            int countFN;

            // Logic
            double logicFN = (double)id / FN;
            countFN = (int)Math.Ceiling(logicFN);
            double remainder = (double)id % FN;

            if (remainder == 0)
            {
                countFN++;
            }

            double costPerFortNights = countFN * defaultCostPerFN; 
            double taxCalOfHST = (costPerFortNights * HSTTax) / 100;
            double finalAmt = costPerFortNights + taxCalOfHST;

            // 1. String Output - $x fortnights at $5.50/FN = $y CAD
            string costPerFortNight = countFN + " fortnights at $5.50/FN = $" + costPerFortNights + " CAD";

            // 2. String Output - HST 13% = $z CAD
            string taxFinal = "HST 13% = $" + taxCalOfHST + " CAD";

            // 3. String Output - Total = $6.22 CAD
            string totalAmt = "Total = $" + finalAmt + " CAD";


            return new string[] { costPerFortNight, taxFinal, totalAmt };
        }
    }
}