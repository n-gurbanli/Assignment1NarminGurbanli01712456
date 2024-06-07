using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1NarminGurbanli01712456.Controllers
{
    
    public class HostingCostController : ApiController


    //Question 6: Output 3 strings which describe the total hosting cost
    // The code has to do mathematical operations to get total hosting cost



    {
        /// <summary>
        /// Creating an operation that outputs 3 strings which describe the total hosting cost
        /// </summary>
        /// <param name="id">Number of days</param>
        /// <returns>
        /// result1 = "({id} / 14 + 1) + " fortnights at $5.50/FN = $" + ({id} / 14 + 1) * 5.50 + " CAD. ";
        /// result2 = "HST 13% = $" + (({id} / 14 + 1) * 5.50) * 0.13 + "CAD. ";
        /// result3 = "Total = $" + ((({id} / 14 + 1) * 5.50) * 0.13) + (({id} / 14 + 1) * 5.50)  + "CAD";
        /// </returns>
        /// <example>
        /// GET localhost:xx/api/HostingCost/0 -> "1 fortnights at $5.50/FN = $5.50 CAD. HST 13% = $0.72 CAD. Total = $6.22 CAD"
        /// GET localhost:xx/api/HostingCost/21 -> "2 fortnights at $5.50/FN = $11.00 CAD. HST 13% = $1.43 CAD. Total = $12.43 CAD"
        /// </example>


        [HttpGet]
        [Route("api/HostingCost/{id}")]
    
        public string HostingCost(int id)
        {

            int fortnights = id / 14 + 1; //this calculates the how many fortnight there are in the days
            double cost = fortnights * 5.50; //this calculates how much I charge my client, using double as there are decimal numbers
            cost = Math.Round(cost, 2); //we did something similair in JavaScript, so I thought that will round the number here too (not sure if that is what you were looking for)
            double HST = cost * 0.13; //this calculates how much is the HST
            HST = Math.Round(HST, 2);
            double total = cost + HST; //this calculates what is the total
            total = Math.Round(total, 2);
            string result1 = fortnights + " fortnights at $5.50/FN = $" + cost + " CAD. ";
            string result2 = "HST 13% = $" + HST + "CAD. ";
            string result3 = "Total = $" + total + "CAD";
            return result1 + result2 + result3;
            
            //I tried to make the outcome .00 if the number doesn't have decimals, but I couldn't figure it out :(
               
        }
      
    }
}
