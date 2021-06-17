using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirthdayCards.Models;

namespace BirthdayCards.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Display the view (empty form)
        [HttpGet]
        public IActionResult CardForm()
        {
            return View(new Card());
        }

        // Receive the data coming from the browser
        [HttpPost]
        public IActionResult CardForm(Models.Card card)
        {
            if (ModelState.IsValid)
            {
                return View("Sent", card);
            }
            else
            {
                return View(card);
            }

        }
    }
}
