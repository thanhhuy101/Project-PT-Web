using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class GioHang
    {
        public int MaGh { get; set; }
        public int? MaSp { get; set; }
        public string TenSp { get; set; }
        public decimal? GiaSp { get; set; }
        public int? SoLuong { get; set; }
        public decimal? TongTien { get; set; }

        public virtual MonAn MaSpNavigation { get; set; }
    }
}
