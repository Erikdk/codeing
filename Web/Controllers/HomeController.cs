using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConsoleApplication;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test([FromQuery]int?x = null, [FromQuery]int? y= null)
        {
         
         Player Player;
         string p =  HttpContext.Session.GetString("Player");
         if (string.IsNullOrWhiteSpace(p))
         {
            Player = new Player();
            Player.placeShip(true, 4, 4);
         }  
         
        else   
        {
          Player = JsonConvert.DeserializeObject<Player>(p);
        }

           if (x.HasValue && y.HasValue)
           {
               Player.shoot(x.Value, y.Value);
           }
           HttpContext.Session.SetString("Player", JsonConvert.SerializeObject(Player));
            return View(Player);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
