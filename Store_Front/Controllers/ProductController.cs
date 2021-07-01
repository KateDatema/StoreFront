using Microsoft.AspNetCore.Mvc;
using Store_Front.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Front.Controllers
{
    public class ProductController: Controller
    {
        StorefontDBContext db = new StorefontDBContext();

        public IActionResult Index()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }

        public IActionResult Replenish()
        {
            List<Product> products = db.Products.ToList();
            List<Product> productRe = new List<Product>();

            foreach(Product p in products) 
            {
                if (p.Quantity < 10)
                {
                    p.Quantity = 10;
                    db.Products.Update(p);
                    db.SaveChanges();
                    productRe.Add(p);
                }
            }
        

            return View(productRe);
        }

        public IActionResult Details(int id)
        {
            Product p = db.Products.Find(id);
            return View(p); 
        }



        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Delete(int Id)
        {
            Product p = db.Products.Find(Id);
            return View(p);
        }

        [HttpPost]
        public IActionResult Delete(Product p)
        {
            // Movie m = db.Movies.Find(Id);
            db.Products.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Product");
        }

        public IActionResult Update(int id)
        {
            Product p = db.Products.Find(id);
            return View(p);
        }

        [HttpPost]
        public IActionResult Update(Product p)
        {
            db.Products.Update(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Product");
        }



        [HttpPost]
        public IActionResult Add(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index", "Product");
        }



    }


}
