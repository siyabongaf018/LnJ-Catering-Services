using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace LnJ_Catering_Services.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public IActionResult verify_user(Models.Detailing verify)
        {
            string username = Request.Form["email"].ToString();
            string password = hash(Request.Form["password"].ToString());



            if (verify.isSuccessLogin(username, password) && verify.isAdmin(username))
            {
                HttpContext.Session.SetInt32("userID", verify.GetUserID(username, password));
                return RedirectToAction("AdminHome", "Admin");

            }
            else if (verify.isSuccessLogin(username, password) && verify.isAdmin(username) == false)
            {
                //return View("../Home/Index");
                HttpContext.Session.SetInt32("userID", verify.GetUserID(username, password));
                return RedirectToAction("Index" , "Home");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }

        }



        public static string hash(string pass)
        {
            var source = pass;
            var hash = "";
            // Creates an instance of the default implementation of the MD5 hash algorithm.
            using (var md5Hash = MD5.Create())
            {
                // Byte array representation of source string
                var sourceBytes = Encoding.UTF8.GetBytes(source);

                // Generate hash value(Byte Array) for input data
                var hashBytes = md5Hash.ComputeHash(sourceBytes);

                // Convert hash byte array to string
                hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

            }
            // Output the MD5 hash
            return hash;
        }

    }
}
