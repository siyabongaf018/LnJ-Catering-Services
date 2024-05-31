using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace LnJ_Catering_Services.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult register_User(Models.Detailing RegisterUser)
        {
            string name = Request.Form["name"].ToString();
            string surname = Request.Form["surname"].ToString();
            string username = Request.Form["email"].ToString();
            string password = hash(Request.Form["password"].ToString());
            string type = Request.Form["user_type"].ToString();
            if (type == "admin")
            {
                if (RegisterUser.register_User(name, surname, username, password, "admin"))
                {
                    return RedirectToAction("Login", "Login");
                }
                else
                {
                    return View("Register");
                }
            }
            else
            {
               // return Content(RegisterUser.register_User(name, surname, username, password, "user").ToString());
                if (RegisterUser.register_User(name, surname, username, password, "user"))
                {
                    return View("../Login/Login");
                }
                else
                {
                    return View("../Register/Register");
                }
            }


        }
        public IActionResult verify_user2(Models.Detailing verify)
        {
            string username = Request.Form["email"].ToString();
            string password = hash(Request.Form["password"].ToString());



            if (verify.isSuccessLogin(username, password) && verify.isAdmin(username))
            {
                return View("../Admin/AdminHome");

            }
            else if (verify.isSuccessLogin(username, password) && verify.isAdmin(username) == false)
            {
                return View("../Home/Index");
            }
            else
            {
                return View("Login");
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
