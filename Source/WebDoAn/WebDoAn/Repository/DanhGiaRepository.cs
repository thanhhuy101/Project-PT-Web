using Admin.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Admin.Repository
{
    public class DanhGiaRepository : IDanhGiaRepository
    {
        private WebsiteBanDoAnContext _ctx;
        public DanhGiaRepository(WebsiteBanDoAnContext ctx)
        {
            _ctx = ctx;
        }

        public List<DanhGium> getallDanhGia()
        {
            return _ctx.DanhGia.Include(x => x.MaKhNavigation).ToList();
        }

        public List<DanhGium> getallDanhGiaByMaSP(int Masp)
        {
            throw new System.NotImplementedException();
        }

        public DanhGium getDanhGia(int MaSP)
        {
            throw new System.NotImplementedException();
        }
    }
}
