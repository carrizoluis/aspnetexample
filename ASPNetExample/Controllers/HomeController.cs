using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNetExample.Models;

namespace ASPNetExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Read()
        {
            return View();
        }

        public IActionResult Save(String barcode, String name, String cost)
        {
            

            Models.Product p = new Models.Product();
            p.barcode = barcode;
            p.name = name;
            p.price = Double.Parse(cost);

            supermarket.products.Add(p);


            return View("Read");
        }


        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
