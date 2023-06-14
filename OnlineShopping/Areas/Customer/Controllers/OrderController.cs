using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Data;
using OnlineShopping.Models;
using OnlineShopping.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(Orders anOrder)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products!=null)
            {
                foreach (var product in products)
                {
                    OrdersDetails orderDetails = new OrdersDetails();
                    orderDetails.ProductsProduct = product.Product;
                    anOrder.OrderDetails.Add(orderDetails);
                }
            }
            anOrder.OrderNo = GetOrderNo();
            _db.Orders.Add(anOrder);
            await _db.SaveChangesAsync();
            HttpContext.Session.Set("products",new List<Products>());
            return View();
        }

        public string GetOrderNo()
        {
            int rowCount = _db.Orders.ToList().Count() + 1;
            return rowCount.ToString("000");
        }


    }
}
