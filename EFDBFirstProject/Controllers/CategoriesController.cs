using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBFirstProject.Models;


namespace EFDBFirstProject.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            NorthwindEntities dbContext = new NorthwindEntities();

            //var categories = dbContext.Categories.ToList();

            List<Category> categories = dbContext.Categories.ToList();

            return View(categories);
        }
    }
}