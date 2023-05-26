using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Data;
using OnlineShopping.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private ApplicationDbContext _db;
        private IHostingEnvironment _he;

        public ProductsController(ApplicationDbContext db, IHostingEnvironment he)
        {
            _db = db;
            _he = he;
        }
        public IActionResult Index()
        {
            return View(_db.Products.Include(c => c.ProductTypes).Include(f => f.SpecialTags).ToList());
        }
        public ActionResult Create()
        {
            ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
            ViewData["TagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "SpecialTag");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Create Post Action Method
        public async Task<IActionResult> Create(Products products, IFormFile image)
        {
            if (image != null)
            {
                var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                await image.CopyToAsync(new FileStream(name, FileMode.Create));
                products.Image = "Images/" + image.FileName;
            }
            if (image == null)
            {
                products.Image = "Images/noimage.jpeg";
            }
            if (ModelState.IsValid)
            {
                _db.Products.Add(products);
                await _db.SaveChangesAsync();
                TempData["save"] = "Product has been saved";
                return RedirectToAction(nameof(Index));
            }
            return View(products);
        }
        //Edit Get Action Method
        public ActionResult Edit(int? id)
        {
            ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
            ViewData["TagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "SpecialTag");

            if (id == null)
            {
                return NotFound();
            }
            var product = _db.Products.Include(c=>c.ProductTypes).Include(f=>f.SpecialTags).ToList().FirstOrDefault(c=>c.Product==id);
            if (product == null)
            {
                return NotFound();
            }


            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Create Post Action Method
        public async Task<IActionResult> Edit(Products products, IFormFile image)
        {
            if (image != null)
            {
                var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                await image.CopyToAsync(new FileStream(name, FileMode.Create));
                products.Image = "Images/" + image.FileName;
            }
            if (image == null)
            {
                products.Image = "Images/noimage.jpeg";
            }
            if (ModelState.IsValid)
            {
                _db.Products.Update(products);
                await _db.SaveChangesAsync();
                TempData["save"] = "Product has been saved";
                return RedirectToAction(nameof(Index));
            }
            return View(products);
        }
    }
}
