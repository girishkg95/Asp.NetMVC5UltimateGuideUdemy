using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC5AssignmentsProject.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Age(int id1, int id2, int id3)
        {
            var dt1 = DateTime.Now;

            var dt2 = new DateTime(id1, id2, id3);

            var age = dt1.Year - dt2.Year;

            return Content(age.ToString());
        }

        public ActionResult FullName(string id1,string id2)
        {
            var fullname = string.Format("{0} {1}",id1,id2);
            return Content(fullname);
        }
    }
}