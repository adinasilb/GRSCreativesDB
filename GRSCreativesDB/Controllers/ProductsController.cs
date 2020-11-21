using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GRSCreativesDB.Models;
using GRSCreativesDB.Data;

namespace GRSCreativesDB.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DBContext _context;
        public ProductsController (DBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}
