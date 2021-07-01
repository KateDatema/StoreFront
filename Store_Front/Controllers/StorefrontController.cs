using Microsoft.AspNetCore.Mvc;
using Store_Front.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Front.Controllers
{
    public class StorefrontController: Controller
    {
        StorefontDBContext db = new StorefontDBContext();
   
        public IActionResult Index()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }

        public IActionResult Buy(int id)
        {
            Product p = db.Products.Find(id);
            User u = db.Users.Find(1);
            u.Money = (int)u.Money - p.Price;
            db.Users.Update(u);
            db.SaveChanges();
            return View(p);
        }

      
        public IActionResult Result(Product p)
        {
            if (p.Quantity > 0)
            { 
                p.Quantity = (int)p.Quantity - 1;
                db.Products.Update(p);
                db.SaveChanges();
            }

            return View(p);
        }


    }
}
