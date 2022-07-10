using Microsoft.AspNetCore.Mvc;
using Customer.Repository;
using Customer.Models;
using System.Collections.Generic;
using System.Linq;

namespace Customer.Controllers
{
    public class DetailController : Controller
    {
        WebsiteBanDoAnContext ctx = new WebsiteBanDoAnContext();
        IGioHangRepository giohangRepository = null;
        public DetailController(IGioHangRepository rep)
        {
            giohangRepository = rep;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Danh sách sản phẩm";
            List<MonAn> lst = giohangRepository.getAllGioHang();
            return View(lst);
        }
        public IActionResult Details(int id)
        {
            ViewBag.Title = "Xem chi tiết";
            List<DanhGium> lst = new List<DanhGium>();
            DanhGiaRepository danhGiaRepository = new DanhGiaRepository(ctx);
            List<DanhGium> temp = danhGiaRepository.getDanhGiaByMasp(id);
            ViewBag.khachhangs = danhGiaRepository.GetDanhGiaWithTenKh();
            foreach (DanhGium danhgia in ViewBag.khachhangs)
            {
                foreach (DanhGium dg in temp)
                {
                    if (dg.MaKh == danhgia.MaKhNavigation.MaKh)
                    {
                        lst.Add(danhgia);
                    }
                }
            }
            ViewBag.danhgias = lst;
            MonAn monan = ctx.MonAns.Where(x => x.MaSp == id).SingleOrDefault();
            return View(monan);
        }
    }
}
