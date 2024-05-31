using LnJ_Catering_Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LnJ_Catering_Services.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        Detailing Detailings = new Detailing();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("userID") == null)
            {
                return RedirectToAction("Login", "Login");

            }
            ViewBag.dish = Detailings.GetDishDetail();
            ViewBag.reviews = Detailings.GetReviewsDetail();
            return View(Detailings.GetMenuDetail());
        }

        public IActionResult Order()
        {

            var userID = HttpContext.Session.GetInt32("userID").ToString();
            if (HttpContext.Session.GetInt32("userID") == null)
            {
                return RedirectToAction("Login", "Login");

            }
            string address = "";
            address = Request.Form["DeliveryAddress"].ToString();
            ViewBag.CartItems = Detailings.CartDataDisplay(userID);

            foreach (var item in Detailings.CartDataDisplay(userID))
            {
                bool valid = Detailings.AddToOrder(userID, item.MenuID, address);

                //remove item from cart
                if (valid)
                {
                    bool validItemsRemove = Detailings.RemoveItemFromCart(userID, item.DishID);

                    //perform a cetain function
                }
            }
            bool Removed = Detailings.CheckOutRemoveAllItemFromCart(userID);
            return RedirectToAction("OrderPlaced","Home");
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult OrderPlaced()
        {
            return View();
        }
        public IActionResult Notifications()
        {
            return View();
        }


        [HttpPost]
        public IActionResult add_review(Models.Food add)
        {
            string review = Request.Form["review"].ToString();
            string rating = Request.Form["rating"].ToString();

            var userID = HttpContext.Session.GetInt32("userID").ToString();
            string []name  = Detailings.GetUserNameAndSurname(userID);

            //if (add.add_user_review("Tshiamo","Monageng", review, rating))
            //{
            //    //return View("../Home/Index");
            //    return RedirectToAction("Index", "Home");
            //}
            if (add.add_user_review(name[0], name[1], review, rating))
            {
                //return View("../Home/Index");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //cart functionality
        [HttpPost]
        public IActionResult AddToCart()
        {
            int DishID = int.Parse(Request.Form["DishID"]);
            var userID = HttpContext.Session.GetInt32("userID").ToString();

            if (HttpContext.Session.GetInt32("userID") == null)
            {
                return RedirectToAction("Login", "Login");

            }

            // return Content("dish id: " + DishID.ToString() + "\nuserID: " + userID);

            bool valid = Detailings.AddToCart(userID, DishID);
            if (valid)
            {
                return RedirectToAction("Cart", "Home");
            }
            //return Content(DishID.ToString());
            return RedirectToAction("Index", "Home");


        }
        [HttpPost]
        public IActionResult RemoveItemInCart()
        {
            int DishID = int.Parse(Request.Form["DishID"]);
            var userID = HttpContext.Session.GetInt32("userID").ToString();
           
            // return Content("dish id: " + DishID.ToString() + "\nuserID: " + userID);

            bool valid = Detailings.RemoveItemFromCart(userID, DishID);
            if (valid)
            {
                return RedirectToAction("Cart", "Home");
            }
            //return Content(DishID.ToString());
            return RedirectToAction("Cart", "Home");


        }
        

        public IActionResult Cart()
        {
            var userID = HttpContext.Session.GetInt32("userID").ToString();
            if (HttpContext.Session.GetInt32("userID") ==null)
            {
                return RedirectToAction("Login", "Login");

            }
            ViewBag.CartItems = Detailings.CartDataDisplay(userID);
            return View();
        }


        public IActionResult SearchFood()
        {
            var userID = HttpContext.Session.GetInt32("userID").ToString();
            if (HttpContext.Session.GetInt32("userID") == null)
            {
                return RedirectToAction("Login", "Login");

            }
            ViewBag.searResults = Detailings.GetSearchResultMenuDetail(TempData["searchFood"].ToString());
           // return Content(TempData["searchFood"].ToString());

            // ViewBag.searResults = Detailings.GetSearchResultMenuDetail(userID);
            return View();
        }

        [HttpPost]
        public IActionResult SearchFoodResult()
        {
            string searchFood="";

            searchFood = Request.Form["Sea"].ToString();

            TempData["searchFood"] = searchFood;
            // return Content(searchFood);
            

            // return RedirectToAction("SearchFood", "Home", ViewBag.searResults);
            return RedirectToAction("SearchFood", "Home");


        }

    }
}
