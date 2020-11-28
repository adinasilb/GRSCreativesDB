using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GRSCreativesDB.Models;
using GRSCreativesDB.Data;
using GRSCreativesDB.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace GRSCreativesDB.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DBContext _context;
        public ProductsController(DBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products.Include(p => p.AliasSKUs.Where(a => a.IsMain)).ThenInclude(a => a.Marketplace)
                .Include(p => p.RawMaterial).ToList();
            //var products = "";
            return View(products);
        }

        [HttpGet]
        public IActionResult AddNewProduct()
        {
            NewProductViewModel newProductViewModel = new NewProductViewModel()
            {
                Marketplaces = _context.Marketplaces.ToList(),
                RawMaterials = _context.RawMaterials.ToList()
            };

            return View(newProductViewModel);
        }

        [HttpPost]
        public IActionResult AddNewProduct(NewProductViewModel newProductViewModel)
        {
            try
            {
                _context.Add(newProductViewModel.AliasSKU.Product);
                _context.SaveChangesAsync();
                newProductViewModel.AliasSKU.ProductID = newProductViewModel.AliasSKU.Product.ProductID;
                newProductViewModel.AliasSKU.IsMain = true;
                _context.Add(newProductViewModel.AliasSKU);
                _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Product(int ProductID)
        {
            Product product = _context.Products.Where(p => p.ProductID == ProductID).FirstOrDefault();
            ProductViewModel productViewModel = new ProductViewModel();

            if (product.JewelryGroup)
            {

            }
            else
            {

            }


            return View(product);
        }
    }
}
