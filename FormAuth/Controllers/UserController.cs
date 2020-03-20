using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FormAuth.Controllers
{/// <summary>
/// This Controller has Login and Success actions
/// </summary>
    public class UserController : Controller
    {/// <summary>
    /// This action is used to get the details
    /// </summary>
    /// <returns></returns>
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// This action is to post the details
        /// </summary>
        /// <param name="formCollection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(FormCollection formCollection)
        {
            if (formCollection.Get("UserName") == "Varun" && formCollection.Get("Password") == "Varun")
            {
                return View("Success");
            }
            else if (formCollection.Get("UserName") == "Admin" && formCollection.Get("Password") == "Admin")
            {
                return View("Success");
            }
            else if (formCollection.Get("UserName") == "User" && formCollection.Get("Password") == "User")
            {
                return View("Success");
            }

            return View("Login");
        }/// <summary>
        /// this action is to dispaly the success login
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public ActionResult Success()
        {
            return View();
        }
    }
}