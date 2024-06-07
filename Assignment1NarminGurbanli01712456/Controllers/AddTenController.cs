using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1NarminGurbanli01712456.Controllers
{
    public class AddTenController : ApiController
    {   //Question 1: Creating a request that adds 10 to response

        // GET localhost:xx/api/AddTen/21 -> 31
        // GET localhost:xx/api/AddTen/0 -> 10
        // GET localhost:xx/api/AddTen/-1 -> 9

        /// <summary>
        /// Creating a request that adds 10 to respons
        /// </summary>
        /// <param name="id">Number to enter</param>
        /// <returns>
        /// {id} + 10
        /// </returns>
        /// <example>
        /// GET localhost:xx/api/AddTen/21 -> 31
        /// GET localhost:xx/api/AddTen/0 -> 10
        /// GET localhost:xx/api/AddTen/-1 -> 9
        /// </example>

        public int GET(int id)
        {
            int sum = id + 10;
            return sum;
        }
    }
}
