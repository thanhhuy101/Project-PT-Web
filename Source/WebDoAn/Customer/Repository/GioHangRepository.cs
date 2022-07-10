using Customer.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Customer.Repository
{
    public class GioHangRepository : IGioHangRepository
    {
        WebsiteBanDoAnContext ctx = new WebsiteBanDoAnContext();
        public List<MonAn> getAllGioHang()
        {
            return ctx.MonAns.Include(x => x.GioHangs).ToList();
        }
    }
}
