using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GRSCreativesDB.Controllers
{
    public class RawMaterials : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
