using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1NarminGurbanli01712456.Controllers
{
    public class GreetingController : ApiController
    {
        //Question 3: Creating a request that returns the string “Hello World!”
        //Here I didnt use [HttpGet] and [Route} because those are two different operations in this contorller (Get and Post)

        /// <summary>
        /// Creating a request that returns the string “Hello World!”
        /// </summary>
        /// <returns> "Hello World!" </returns>
        /// <example>
        /// POST: -d "" localhost:xx/api/Greeting -> "Hello World!"
        /// </example>

        public string Post()
        {
            string greeting = "Hello World!";
            return greeting; //returns the words "Hello World!

            //Also, We can just write return "Hello World";
        }

        //Question 4: Creating a request that returns the string “Greetings to {id} people!” where id is an integer value

        /// <summary>
        /// Creating a request that returns the string “Greetings to {id} people!” where id is an integer value
        /// </summary>
        /// <param name="id">Number to enter</param>
        /// <returns> "Greetings to " + {id} + " people!" </returns>
        /// <example>
        /// GET localhost/xx/api/Greeting/3 -> "Greetings to 3 people!"
        /// GET localhost/xx/api/Greeting/6 -> "Greetings to 6 people!"
        /// GET localhost/xx/api/Greeting/0 -> "Greetings to 3 people!"
        /// </example>

        public string Get(int id)
        {
            string message = "Greetings to " + id + " people!";
            return message;
        }

    }
}
