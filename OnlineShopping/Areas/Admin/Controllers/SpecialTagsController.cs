using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Data;
using OnlineShopping.Models;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SpecialTagsController : Controller
    {
        private ApplicationDbContext _db;

        public SpecialTagsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //var data = _db.ProductTypes.ToList();
            return View(_db.SpecialTags.ToList());
        }

        //Create Get Action Method
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Create Post Action Method
        public async Task<IActionResult> Create(SpecialTags specialTags)
        {
            if (ModelState.IsValid)
            {
                _db.SpecialTags.Add(specialTags);
                await _db.SaveChangesAsync();
                TempData["save"] = "Special tag has been saved";
                return RedirectToAction(nameof(Index));
            }
            return View(specialTags);
        }

        //Edit Get Action Method
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialTags = _db.SpecialTags.Find(id);
            if (specialTags == null)
            {
                return NotFound();
            }


            return View(specialTags);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Create Post Action Method
        public async Task<IActionResult> Edit(SpecialTags specialTags)
        {
            if (ModelState.IsValid)
            {
                _db.Update(specialTags);
                await _db.SaveChangesAsync();
                TempData["save"] = "Special tag edited";
                return RedirectToAction(nameof(Index));
            }
            return View(specialTags);
        }
        //Details Get Action Method
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialTag = _db.SpecialTags.Find(id);
            if (specialTag == null)
            {
                return NotFound();
            }


            return View(specialTag);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Details Post Action Method
        public IActionResult Details(SpecialTags specialTags )
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
            var specialTag = _db.SpecialTags.Find(id);
            if (specialTag == null)
            {
                return NotFound();
            }


            return View(specialTag);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Delete Post Action Method
        public async Task<IActionResult> Delete(int id, SpecialTags specialTags)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != specialTags.Id)
            {
                return NotFound();
            }
            var specialTag = _db.SpecialTags.Find(id);
            if ( specialTag== null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(specialTag);
                await _db.SaveChangesAsync();
                TempData["save"] = "Special tag deleted";
                return RedirectToAction(nameof(Index));
            }
            return View(specialTag);
        }
    }
}
