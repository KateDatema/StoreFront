using Microsoft.AspNetCore.Mvc;
using Store_Front.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Front.Controllers
{
    public class UserController: Controller
    {
        StorefontDBContext db = new StorefontDBContext();

        public IActionResult Index(int id)
        {
            User u = db.Users.Find(1);
            return View(u);
        }
    }
}
