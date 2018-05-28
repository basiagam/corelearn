using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    public class AboutController : Controller
    {
       public string Phone()
        {
            return "1+555+555+5555";
        }
        public string Address()
        {
            return "USA";
        }
    }
}