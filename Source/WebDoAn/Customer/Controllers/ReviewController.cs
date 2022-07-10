using Microsoft.AspNetCore.Mvc;
using Customer.Repository;
using Customer.Models;
using System.Collections.Generic;

namespace Customer.Controllers
{
    public class ReviewController : Controller
    {
        private IDanhGiaRepository _danhgia;
        public ReviewController(IDanhGiaRepository danhgia)
        {
            _danhgia = danhgia;
        }
        public IActionResult Index()
        {
            ViewBag.review = _danhgia.getAllDanhGia(); 
            return View();
        }
    }
}
