using Microsoft.AspNetCore.Mvc;
using Admin.Repository;
using System.Collections.Generic;
using Admin.Models;

namespace Admin.Controllers
{
    public class DanhGiaController : Controller
    {
        private IDanhGiaRepository _danhGia;
        public DanhGiaController(IDanhGiaRepository danhGia)
        {
            _danhGia = danhGia;
        }
        public IActionResult Index()
        {
            List<DanhGium> danhgia = _danhGia.getallDanhGia();
            ViewBag.danhgia = danhgia;

            return View();
        }
    }
}
