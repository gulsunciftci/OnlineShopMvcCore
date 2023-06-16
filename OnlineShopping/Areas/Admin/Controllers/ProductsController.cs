using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
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

        [HttpPost]
        //POST Index action method
        public IActionResult Index(decimal? lowAmount, decimal? largeAmount)
        {
            var products = _db.Products.Include(c => c.ProductTypes).Include(c => c.SpecialTags).Where(c => c.Price >= lowAmount && c.Price <= largeAmount).ToList();
            if (lowAmount == null || largeAmount == null)
            {
                products = _db.Products.Include(c => c.ProductTypes).Include(c => c.SpecialTags).ToList();
            }
            return View(products);
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
                var searchProduct = _db.Products.FirstOrDefault(c => c.Name == products.Name);
                if (searchProduct != null)
                {
                    ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
                    ViewData["TagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "SpecialTag");
                    ViewBag.message = "This product is already exist";

                    return View(products);
                }
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
        //Details Get Action Method
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _db.Products.Include(c => c.ProductTypes).Include(f => f.SpecialTags).ToList().FirstOrDefault(c => c.Product == id);
            if (product == null)
            {
                return NotFound();
            }


            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Details Post Action Method
        public IActionResult Details(Products products)
        {

            return RedirectToAction(nameof(Index));

        }
        //Delete Get Action Method
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _db.Products.Include(c => c.ProductTypes).Include(f => f.SpecialTags).ToList().Where(c => c.Product == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }


            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Delete Post Action Method
        public async Task<IActionResult> Delete(int id, Products products)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != products.Product)
            {
                return NotFound();
            }
            var product = _db.Products.Include(c => c.ProductTypes).Include(f => f.SpecialTags).ToList().FirstOrDefault(c => c.Product == id);
            if (product == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(product);
                await _db.SaveChangesAsync();
                TempData["save"] = "Product deleted";
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
    }
}
