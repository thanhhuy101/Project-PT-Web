using Customer.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Customer.Repository
{
    public class DanhGiaRepository : IDanhGiaRepository
    {
        private WebsiteBanDoAnContext _ctx;
        public DanhGiaRepository(WebsiteBanDoAnContext ctx)
        {
            _ctx = ctx;
        }

        public void createDanhGia(DanhGium danhgia)
        {
            _ctx.DanhGia.Add(danhgia);
            _ctx.SaveChanges();
        }

        public List<DanhGium> getAllDanhGia()
        {
            return _ctx.DanhGia.Include(x => x.MaKhNavigation).ToList();
        }

        public DanhGium GetDanhGia(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<DanhGium> getDanhGiaByMasp(int MaSp)
        {
            List<DanhGium> temp = new List<DanhGium>();
            foreach (DanhGium dg in _ctx.DanhGia)
            {
                if (dg.MaSp == MaSp)
                {
                    temp.Add(dg);
                }
            }
            return temp;
        }

        public List<DanhGium> GetDanhGiaWithTenKh()
        {
            return _ctx.DanhGia.Include(x => x.MaKhNavigation).ToList();
        }
    }
}
