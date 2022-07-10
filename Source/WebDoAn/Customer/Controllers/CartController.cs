using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Session;
using Customer.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace Customer.Controllers
{
    public class CartController : Controller
    {
        WebsiteBanDoAnContext ctx = new WebsiteBanDoAnContext();
        public IActionResult ShoppingCart()
        {
            var sessionId = HttpContext.Session.Id;
            ViewBag.sessionId = sessionId;
            ViewBag.Title = "ShoppingCart";

            List<ItemCart> items = null;
            // doc session
            var yourcart = HttpContext.Session.GetString("yourcart");
            //chuyen string json --> object

            if (yourcart != null)
            {
                items = (List<ItemCart>)JsonSerializer.Deserialize(yourcart, typeof(List<ItemCart>));
            }
            else
            {
                items = new List<ItemCart>();
            }
            ViewBag.Cart = items;
            // total
            decimal total = 0;
            foreach (ItemCart item in items)
            {
                total += item.Price * item.Quantity;

            }
            ViewBag.Total = total;

            return View();
        }
        [HttpPost]
        public IActionResult AddToCart()
        {
            int id = int.Parse(Request.Form["MaSp"].ToString());
            int quantity = int.Parse(Request.Form["SoLuong"].ToString());

            List<ItemCart> items = null;

            var yourcart = HttpContext.Session.GetString("yourcart");


            if (yourcart != null)
            {
                items = (List<ItemCart>)JsonSerializer.Deserialize(yourcart, typeof(List<ItemCart>));
            }
            else
            {
                items = new List<ItemCart>();
            }

            MonAn prod = ctx.MonAns.Where(x => x.MaSp == id).SingleOrDefault();

            ItemCart item = new ItemCart()
            {
                Id = id,
                Quantity = quantity,
                Image = prod.HinhAnh,
                Price = (decimal)prod.GiaSp,
                Name = prod.TenSp,
            };

            items.Add(item);
            HttpContext.Session.SetString("yourcart", JsonSerializer.Serialize(items, typeof(List<ItemCart>)));

            return RedirectToAction("ShoppingCart");
        }
        public IActionResult Bill()
        {
            /*            var sessionId = HttpContext.Session.Id;
                        ViewBag.sessionId = sessionId;*/
            ViewBag.Title = "Hóa đơn";

            List<ItemCart> items = null;
            //doc session
            var yourcart = HttpContext.Session.GetString("yourcart");
            //chuyen string json --> object
            if (yourcart != null)
            {
                items = (List<ItemCart>)JsonSerializer.Deserialize(yourcart, typeof(List<ItemCart>));
            }
            else
            {
                items = new List<ItemCart>();
            }
            ViewBag.Cart = items;
            // total
            decimal total = 0;
            foreach (ItemCart item in items)
            {
                total += item.Price * item.Quantity;

            }
            ViewBag.Total = total;

            return View();
        }
        [HttpPost]
        public IActionResult Bill(HoaDon bill)
        {
            List<ItemCart> items = null;
            //doc session
            var yourcart = HttpContext.Session.GetString("yourcart");
            //chuyen string json --> object
            if (yourcart != null)
            {
                items = (List<ItemCart>)JsonSerializer.Deserialize(yourcart, typeof(List<ItemCart>));
            }
            else
            {
                items = new List<ItemCart>();
            }
            ViewBag.Cart = items;
            // total
            decimal total = 0;
            foreach (ItemCart item in items)
            {
                total += item.Price * item.Quantity;

            }
            ViewBag.Total = total;

            if (ModelState.IsValid)
            {
                    ctx.HoaDons.Add(bill);
                    ctx.SaveChanges();
                    return RedirectToAction("bill");
            }
            else
            {
                return View(bill);
            }
        }
    }
}
