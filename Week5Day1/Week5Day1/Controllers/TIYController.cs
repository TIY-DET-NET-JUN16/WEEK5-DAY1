using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week5Day1.Controllers
{
    public class TIYController : Controller
    {
        // GET: TIY
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int id = 1)
        {
            //return HttpUtility.HtmlEncode("Hello my name is " + name + "; ID = " + id);

            ViewBag.Name = name;
            ViewBag.ID = id;

            return View();
        }
    }
}