using LnJ_Catering_Services.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LnJ_Catering_Services.Controllers
{
    public class AdvertiseController : Controller
    {
        public IActionResult Advert(Detailing Detailing)
        {
            return View(Detailing.GetMenuDetail());
        }
        
    }
}
