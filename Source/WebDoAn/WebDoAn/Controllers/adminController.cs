using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.Repository;

namespace Admin.Controllers
{
    public class adminController : Controller
    {
      
        WebsiteBanDoAnContext ctx = new WebsiteBanDoAnContext();
        public IActionResult Index()
        {
            return View();
        }
        //-------------CATEGORY--------------
        public IActionResult GetAllCategories()
        {

            //select * from Category
            List<Category> categories = ctx.Categories.ToList();

            return View(categories);
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        public IActionResult DeleteCategory(int id)
        {
            // tim doi tuong có id
            //select * from categories where CCategoryId = id 
            Category c = ctx.Categories.Where(x => x.MaLoai == id).SingleOrDefault();

            //xoa du lieu

            ctx.Categories.Remove(c);
            ctx.SaveChanges();

            return RedirectToAction("GetAllCategories");
        }

        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            if (ModelState.IsValid)
            {
                //insert db
                //check ten loai
                Category ct = ctx.Categories.Where(x => x.TenLoai == c.TenLoai).SingleOrDefault();
                if(ct != null)
                {
                    ModelState.AddModelError(string.Empty, "Tên loại đã tồn tại!!");
                    return View(c);
                }
                else
                {
                    ctx.Categories.Add(c);
                    ctx.SaveChanges();
                    return RedirectToAction("GetAllCategories");
                }
                
            }
            else
            {
                return View(c);
            }         
        }

        public IActionResult EditCategory(int id)
        {
            // tim doi tuong có id
            //select * from categories where CCategoryId = id 
            Category c = ctx.Categories.Where(x => x.MaLoai == id).SingleOrDefault();
            return View(c);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category c)
        {

            // tim doi tuong co trong db tuong ung ma cateid
            
            Category c_indb = ctx.Categories.Where(x => x.MaLoai == c.MaLoai).SingleOrDefault();
            if (c_indb != null)
            {
                c_indb.TenLoai = c.TenLoai;
                c_indb.MoTa = c.MoTa;

            }
            ctx.SaveChanges();
            //cap nhat thong tin
            return RedirectToAction("GetAllCategories");
        }

        //-------------SANPHAM--------------
        public IActionResult GetAllSanPham()
        {

            //select * from San pham
            List<MonAn> sp = ctx.MonAns.ToList();

            return View(sp);
        }

        public IActionResult AddSanPham()
        {
            List<Category> categories = ctx.Categories.ToList();
            ViewBag.SanPham = categories;
            return View();
        }

        public IActionResult DeleteSanPham(int id)
        {
            // tim doi tuong có id
            //select * from sanpham where masp = id 
            MonAn sp = ctx.MonAns.Where(x => x.MaSp == id).SingleOrDefault();

            //xoa du lieu

            ctx.MonAns.Remove(sp);
            ctx.SaveChanges();

            return RedirectToAction("GetAllSanPham");
        }

        [HttpPost]
        public IActionResult SaveSanPham(MonAn sp)
        {
            //C1: có check
            //if (ModelState.IsValid)
            //{
            //    MonAn ma = ctx.MonAns.Where(x=>x.TenSp == sp.TenSp).SingleOrDefault();
            //    if(ma != null)
            //    {
            //        ModelState.AddModelError(string.Empty, "Tên sản phẩm đã tồn tại!!!!");
            //        return View(sp);
            //    }
            //    else
            //    {
            //        //insert db
            //        ctx.MonAns.Add(sp);
            //        ctx.SaveChanges();
            //        return RedirectToAction("GetAllSanPham");
            //    }
            //}
            //else
            //{
            //    return View(sp);
            //}

            //C2: ko có check
            //ctx.MonAns.Add(sp);
            //ctx.SaveChanges();
            //return RedirectToAction("GetAllSanPham");

            //C3: upload ảnh item
            try
            {
                var formFile = Request.Form.Files[0];
                string rootPath = @"D:\N3CN22\Web\PTWeb\Project\WebDoAn\WebDoAn\wwwroot\images\";
                string rootPath2 = @"D:\N3CN22\Web\PTWeb\Project\WebDoAn\Customer\wwwroot\images";

                var fileName = formFile.FileName;

                string path = rootPath + fileName;
                string path2 = rootPath2 + fileName;

                var stream = System.IO.File.Create(path);
                var stream2 = System.IO.File.Create(path2);

                formFile.CopyTo(stream);
                formFile.CopyTo(stream2);
                MonAn spindb = new MonAn()
                {
                    HinhAnh = fileName,
                    MaSp = sp.MaSp,
                    MaLoai = sp.MaLoai,
                    TenSp = sp.TenSp,
                    GiaSp = sp.GiaSp,
                    MoTa = sp.MoTa,
                };
                stream.Close();
                stream2.Close();
                ctx.MonAns.Add(spindb);
                ctx.SaveChanges();
                return RedirectToAction("GetAllSanPham");
            }
            catch (Exception ex)
            {
                
            }
            return View();
        }

        public IActionResult EditSanPham(int id)
        {
            List<Category> categories = ctx.Categories.ToList();
            ViewBag.SanPham = categories;
            // tim doi tuong có id
            //select * from Sanpham where masp = id 
            MonAn sp = ctx.MonAns.Where(x => x.MaSp == id).SingleOrDefault();
          
            return View(sp);
        }

        [HttpPost]
        public IActionResult UpdateSanPham(MonAn sp)
        {

            // tim doi tuong co trong db tuong ung ma spid
            try
            {
                var formFile = Request.Form.Files[0];
                string rootPath = @"D:\N3CN22\Web\PTWeb\Project\WebDoAn\WebDoAn\wwwroot\images\";
                string rootPath2 = @"D:\N3CN22\Web\PTWeb\Project\WebDoAn\Customer\wwwroot\images";

                var fileName = formFile.FileName;
                string path = rootPath + fileName;
                string path2 = rootPath2 + fileName;

                var stream = System.IO.File.Create(path);
                var stream2 = System.IO.File.Create(path2);

                formFile.CopyTo(stream);
                formFile.CopyTo(stream2);
                MonAn sp_indb = ctx.MonAns.Where(x => x.MaSp == sp.MaSp).SingleOrDefault();
                if (sp_indb != null)
                {
                    sp_indb.MaLoai = sp.MaLoai;
                    sp_indb.TenSp = sp.TenSp;
                    sp_indb.GiaSp = sp.GiaSp;
                    sp_indb.MoTa = sp.MoTa;
                    sp_indb.HinhAnh = fileName;

                }
                ctx.SaveChanges();
                stream.Close();
                stream2.Close();
                //cap nhat thong tin
                return RedirectToAction("GetAllSanPham");
            }catch (Exception ex)
            {

            }
            return View();
        }

        //-------------CUSTOMER--------------

        public IActionResult GetAllCustomer()
        {

            //select * from Customer
            List<User> cus = ctx.Users.ToList();

            return View(cus);
        }

        //-------------HÓA ĐƠN--------------

        public IActionResult GetAllHoaDon()
        {

            //select * from HoaDon
            List<HoaDon> hd = ctx.HoaDons.ToList();

            return View(hd);
        }

        //-------------REVIEW--------------

        public IActionResult GetAllReview()
        {

            //select * from Review
            List<DanhGium> re = ctx.DanhGia.ToList();

            return View(re);
        }


        //////////////////////////////////////////////
        //[HttpGet]
        //public IActionResult AddItem()
        //{
        //    MonAn monan = new MonAn();

        //    ViewBag.categories = _rep.getAllCategories();
        //    return View(monan);
        //}

        //[HttpPost]
        //public IActionResult SaveItem(MonAn monan)
        //{
        //    _rep.createItem(monan);
        //    return RedirectToAction("GetAllSanPham");

        //}
    }
}
