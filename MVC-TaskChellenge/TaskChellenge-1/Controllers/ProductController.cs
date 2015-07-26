using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TaskChellenge_1.Models;

namespace TaskChellenge_1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> Products = Product.GetProducts();
            return View(Products);
        }

        public ActionResult CreateNewProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewProduct(Product NewProduct)
        {
            if (ModelState.IsValid)
            {
                NewProduct.CreateProduct();
                ViewData["SuccessMessgae"] = "Product Successfully Created";
            }
            return View(NewProduct);
        }

        public ActionResult ViewProduct(int? id)
        {
            Product ViewProduct = Product.GetProduct(Convert.ToInt32(id));
            return View(ViewProduct);
        }

        public ActionResult AddComment(int id)
        {
            Product ViewProduct = Product.GetProduct(Convert.ToInt32(id));
            ViewData["Product"] = ViewProduct;
            return View();
        }

        [HttpPost]
        public ActionResult AddComment(int id, UserComment _UserComment)
        {
            Product ViewProduct = Product.GetProduct(Convert.ToInt32(id));
            ViewData["Product"] = ViewProduct;
            if (ModelState.IsValid) {
                ViewProduct.AddComment(_UserComment);
                ViewData["SuccessMessgae"] = "Comment Successfully Add";
            }
            return View(_UserComment);
        }
    }
}
