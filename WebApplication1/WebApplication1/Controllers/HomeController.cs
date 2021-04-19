using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View("OurCompanyProducts");
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult GetEmpName(int EmpId)
        {
            var employees = new[] {
                new {EmpID = 1, EmpName = "Scott", Salary = 8000},
                new {EmpID = 2, EmpName = "Smith", Salary = 2540},
                new {EmpID = 3, EmpName = "Allen", Salary = 9400},
            };
            string matchEmpName = null;
            foreach (var item in employees)
            {
                if (item.EmpID == EmpId)
                {
                    matchEmpName = item.EmpName;
                }
            }
            //return new ContentResult() { Content = matchEmpName, ContentType = "text/plain" };
            return Content(matchEmpName, "text/plain");
        }

        public ActionResult GetPaySlip(int EmpId)
        {
            string fileName = "~/PaySlip" + EmpId + ".txt";
            return File(fileName, "application/text"); //currently wrong type
        }

        public ActionResult EmpFacebookPage(int EmpId)
        {
            string fbUrl = "http://www.facebook.com/emp" + EmpId;
            return Redirect(fbUrl);
        }

        public ActionResult StudentDetails()
        {
            ViewBag.StudentId = 101;
            ViewBag.StudentName = "Scott";
            ViewBag.Marks = 80;
            ViewBag.NoOfSemesters = 6;
            ViewBag.Subjects = new List<string>() { "Math", "Physics", "Chemistry" };
            return View();
        }

        public ActionResult RequestExample()
        {
            ViewBag.URL = Request.Url;
            ViewBag.PhysicalApplicationPath = Request.PhysicalApplicationPath;
            ViewBag.Path = Request.Path;
            ViewBag.BrowserType = Request.Browser.Type;
            ViewBag.QueryString = Request.QueryString["n"];
            ViewBag.Headers = Request.Headers["Accept"];
            ViewBag.HttpMethod = Request.HttpMethod;
            return View();
        }

        public ActionResult ResponseExample()
        {
            Response.Write("Hello From ResponseExample");
            Response.ContentType = "text/plain";
            Response.Headers["Server"] = "My Server";
            Response.StatusCode = 500;
            return View();
        }
    }
}