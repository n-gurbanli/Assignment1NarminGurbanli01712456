using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;

namespace Assignment1NarminGurbanli01712456.Controllers
{
    public class NumberMachineController : ApiController
    {
        //Question 5: Creating a method which has an input {id}, and applies four mathematical operations to it

        /// <summary>
        /// Creating a method which has an input {id}, and applies four mathematical operations to it
        /// </summary>
        /// <param name="id">the number to enter</param>
        /// <returns>"Addition: {id} + 4, Square: {id} * {id}, Subtraction: {id} - 10, Division: {id} / 2"
        /// </returns>
        /// <example>
        /// GET localhost:xx/api/NumberMachine/100 -> "Addition: 104, Square: 10000, Subtraction: 90, Division: 50"
        /// GET localhost:xx/api/NumberMachone/78 -> "Addition: 82, Square: 6084, Subtraction: 68, Division: 39"
        /// </example>

        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public string NumberMachine(int id)
        {
            int sum = id + 4;
            int square = id * id;
            int sub = id - 10;
            int div = id / 2; //Four mathematical operations

            string result = "Addition: " + sum + ", Square: " + square + ", Subtraction: " + sub + ", Division: " + div;
            return result;

        }


    }
}
