using LnJ_Catering_Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LnJ_Catering_Services.Controllers
{
    public class AdminController : Controller
    {
        Detailing Detailings = new Detailing();
        public IActionResult AdminHome()
        {
            ViewBag.dish = Detailings.GetDishDetail();
            return View(Detailings.GetMenuDetail());
        }
        public IActionResult AdminReviewsRatings()
        {
            ViewBag.reviews = Detailings.GetReviewsDetail();
            return View();
        }
        public IActionResult AdminCustomerOrders()
        {
            ViewBag.Orders = Detailings.GetOrders();
            return View();
        }
        public IActionResult AdminEditFood()
        {
            var MenuID = HttpContext.Session.GetInt32("MenuID").ToString();
            ViewBag.PassedFoodId = Detailings.GetEditMenuResultMenuDetail(int.Parse(MenuID.ToString()));

            return View();
        }

        [HttpPost]
        public IActionResult EditMenuDetails()
        {
            int MenuID = int.Parse(Request.Form["MenuId"]);


            TempData["MenuID"] = MenuID;
            HttpContext.Session.SetInt32("MenuID", MenuID);

            return RedirectToAction("AdminEditFood", "Admin");

        }

        public IActionResult AdminRegisteredCustomers()
        {
            ViewBag.users = Detailings.getCustomers();
            return View(Detailings.getCustomers());
        }

        [HttpPost]
        public IActionResult UpdateFood()
        {
            int MenuID = int.Parse(Request.Form["MenuId"]);
            string UpdatedMenuName = Request.Form["UpdatedMenuName"].ToString();
            int UpdatedMenuRating = int.Parse(Request.Form["UpdatedMenuRating"].ToString());
            string UpdatedMenuDescription = Request.Form["UpdatedMenuDescription"].ToString();
            double UpdatedMenuPrice = double.Parse(Request.Form["UpdatedMenuPrice"].ToString());


            bool validate = Detailings.UpdateMenuDetails(MenuID,UpdatedMenuName,UpdatedMenuRating,UpdatedMenuDescription,UpdatedMenuPrice);

            if (validate)
            {
                return RedirectToAction("AdminHome", "Admin");
            }
            TempData["MenuID"] = MenuID;

            return RedirectToAction("AdminEditFood", "Admin");

        }
    }
}
