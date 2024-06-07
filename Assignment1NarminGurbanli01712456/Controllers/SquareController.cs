using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1NarminGurbanli01712456.Controllers
{
    public class SquareController : ApiController
    {
        //Question 2: Creating a request that returns the square of the integer input
        

        /// <summary>
        /// Creating a request that returns the square of the integer input
        /// </summary>
        /// <param name="id">the number to enter</param>
        /// <returns>
        /// {id} * {id}
        /// </returns>
        /// <example>
        /// GET localhost:xx/api/Square/2 -> 4
        /// GET localhost:xx/api/Square/-2 -> 4
        /// GET localhost:xx/api/Square/10 -> 100
        /// </example>

        public int GET(int id)
        {
            int square = id * id; //calculating the square of the number
            return square; //returning the calculated square

        }
    }
}
