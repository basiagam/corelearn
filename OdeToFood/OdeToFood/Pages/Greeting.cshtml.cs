using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Services;

namespace OdeToFood.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter _greeter;

        public GreetingModel(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public string CurrentGreeting { get; set; }
        public void OnGet(string name)
        {
            CurrentGreeting = $"{name} : {_greeter.GetMessageOfTheDay()}";
        }
    }
}