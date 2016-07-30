using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectBarcelona.Controllers
{
    public class HomeController : Controller{

        public IActionResult Index(){
            ViewData["Title"] = "Project Barcelona";
            return View();
        }
        
    }
}