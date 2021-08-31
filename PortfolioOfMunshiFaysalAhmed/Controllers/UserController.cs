using PortfolioOfMunshiFaysalAhmed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioOfMunshiFaysalAhmed.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(user_msg obj)

        {
            if (ModelState.IsValid)
            {
                portfolioEntities db = new portfolioEntities();
                db.user_msg.Add(obj);
                db.SaveChanges();
            }
            ViewBag.Message = "Message has been successfullly submitted!!!";
            return View(obj);
        }
    }
}