using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBFirstProject.Models;
using System.Data.SqlClient;

namespace EFDBFirstProject.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindEntities dbContext = new NorthwindEntities();
        // GET: Products
        public ActionResult Index()
        {
            
            List<Product> products = dbContext.Products.ToList();

            return View(products);
        }

        public ActionResult Show()
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@CategoryID", 2)
                //you can add more parameters here
            };
            List<Product> products = dbContext.Database.SqlQuery<Product>("exec ShowProductsByCategoryID_Result @CategoryID", sqlParameters).ToList();

            return View(products);
        }
    }
}