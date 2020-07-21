using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotNetCoreSqlDb.Models;

namespace nutribemwebapi.Controllers
{
    public class ProductsController : Controller
    {

        private readonly MyDatabaseContext _context;
        private readonly ILogger _logger;

        public ProductsController(MyDatabaseContext context, ILogger<ProductsController> logger)
        {
            _logger = logger;
            _context = context;
        }



        // RETURN ALL PRODUCTS - EXEMPLO URL: http://localhost:9008/products ou http://localhost:9008/products/index
        [HttpGet]
        public ActionResult Index()
        {
            var products = _context.Product.ToList();

            if (products.Any())
            {
                return Json(products, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
            }
            return NotFound();
        }

        // RETURN PRODUCT BY ID - EXEMPLO URL: http://localhost:9008/products/id/2
        [HttpGet]
        public ActionResult Id(int id)
        {
            var product = _context.GetProductById(id);

            if (product != null)
            {
                return Json(product, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
            }
            return NotFound();
        }

        // RETURN PRODUCT BY NAME - EXEMPLO URL: http://localhost:9008/products/name/?name=Maca
        [HttpGet]
        public ActionResult Name(string name)
        {
            var product = _context.GetProductByName(name);
            if (product != null)
            {
                return Json(product, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(product);
                    _context.SaveChanges();
                    return Json(product);
                }
                catch
                {
                    return StatusCode(500);

                }
            }
            return BadRequest();
        }

        public ActionResult TestAdd()
        {
            var product1 = new Product()
            {
                Name = "Coca-cola",
                SmallPortionRatio = 200,
                MediumPortionRatio = 330,
                LargePortionRatio = 500,
                Kcals = 42,
                Protein = 0,
                Fat = 0,
                SaturatedFat = 0,
                CarboHidrate = 14,
                Sugar = 14,
                Type = "Refrigerante",
                Description = "",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,
            };

            var product2 = new Product()
            {
                Name = "Maca",
                SmallPortionRatio = 70,
                MediumPortionRatio = 80,
                LargePortionRatio = 100,
                Kcals = 52,
                Protein = 0,
                Fat = 0.2M,
                SaturatedFat = 0,
                CarboHidrate = 14,
                Sugar = 10,
                Type = "Fruta",
                Description = "",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,
            };

            var product3 = new Product()
            {
                Name = "Batatas Fritas",
                SmallPortionRatio = 200,
                MediumPortionRatio = 400,
                LargePortionRatio = 600,
                Kcals = 312,
                Protein = 3.4M,
                Fat = 15,
                SaturatedFat = 2.3M,
                CarboHidrate = 41,
                Sugar = 0.3M,
                Type = "Fast-Food",
                Description = "",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,
            };

            try
            {
                _context.Add(product1);
                _context.Add(product2);
                _context.Add(product3);
                _context.SaveChanges();
                return Json(new List<Product>() {product1, product2, product3});
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
