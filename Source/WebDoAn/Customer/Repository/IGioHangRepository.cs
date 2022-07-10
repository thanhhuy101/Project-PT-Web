using Customer.Models;
using System.Collections.Generic;

namespace Customer.Repository

{
    public interface IGioHangRepository
    {
        public List<MonAn> getAllGioHang();
    }
}
