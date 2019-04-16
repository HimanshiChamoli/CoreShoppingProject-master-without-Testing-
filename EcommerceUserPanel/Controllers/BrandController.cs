using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceUserPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceUserPanel.Controllers
{
    public class BrandController : Controller
    {
        ShoppingDemoooo2Context context = new ShoppingDemoooo2Context();
        public IActionResult Index()
        {
            var brand = context.Brands.ToList();
            return View(brand);
        }
        public IActionResult ProductDisplay(int id)
        {
            var p = context.Products.Where(x => x.BrandId == id).ToList();
            return View(p);
        }
    }
}