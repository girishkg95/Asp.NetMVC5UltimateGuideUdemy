using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC5AssignmentsProject.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Add(int id1,int id2)
        {
            var sum = id1 + id2;
            return Content(sum.ToString());
        }

        public ActionResult Square(int id1)
        {
            var sqr = id1 * id1;
            return Content(sqr.ToString());
        }
    }
}