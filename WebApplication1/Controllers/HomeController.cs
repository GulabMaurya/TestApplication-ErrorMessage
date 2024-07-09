using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["ErrorMessage"] != null)
            {
                ViewBag.MyErrorMessage = Session["ErrorMessage"];
            }


            return View();
        }

        public ActionResult About()
        {
            try
            {
                //   ViewBag.Message = "Your application description page.";
                int a = 10;
                int b = 0;
                int c = a / b;

            }catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index");

            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}