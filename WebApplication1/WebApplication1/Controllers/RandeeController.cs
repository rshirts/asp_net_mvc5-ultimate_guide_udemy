using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class RandeeController : Controller
    {
        // GET: Randee
        public ActionResult Index(string type)
        {
            switch(type)
            {
                case "file":
                    return File("~/PaySlip1.txt", "text/plain");
                default:
                    return RedirectToAction("Default");
            }
            
        }

        public ActionResult Default()
        {
            return View();
        }
    }
}