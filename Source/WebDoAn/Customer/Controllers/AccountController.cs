using Customer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Customer.Repository;

namespace WebsiteDoAn.Controllers
{
    public class AccountController : Controller
    {
        WebsiteBanDoAnContext ctx = new WebsiteBanDoAnContext();
        public IActionResult Login()
        {
            ViewBag.Title = "Đăng nhập";
            return View();
        }
        [HttpPost]
        public IActionResult CheckAccount(User user)
        {
            var temp = false;
            foreach(User adm in ctx.Users)
            {
                if(user.Sdt == adm.Sdt && user.Matkhau == adm.Matkhau)
                {
                    temp = true;
                    return RedirectToAction("Index", "Home");
                }
            }
            if(temp == false)
            {
                ViewBag.Message = string.Format("Vui lòng kiểm tra lại tài khoản hoặc mật khẩu không chính xác");
                return View("Login");
            }
            else
            {
                return View("Login");
            }
        }
        public IActionResult Register()
        {
            ViewBag.Title = "Đăng ký";
            User register = new User();
            return View(register);
        }
        [HttpPost]
        public IActionResult Register(User register)
        {
            if (ModelState.IsValid)
            {
                // check email
                User c = ctx.Users.Where(x => x.TenKh == register.TenKh).SingleOrDefault();
                if (c != null)
                {
                    ModelState.AddModelError(string.Empty, "Tên tài khoản đã tồn tại!!");
                    return View(register);
                }
                else
                {
                    ctx.Users.Add(register);
                    ctx.SaveChanges();
                    return RedirectToAction("Register");
                }
            }
            else
            {
                return View(register);
            }
            if (ModelState.IsValid)
            {
                ctx.Users.Add(register);
                ctx.SaveChanges();
                return RedirectToAction("register");
            }
            else
            {
                return View(register);
            }
        }
    }
}
