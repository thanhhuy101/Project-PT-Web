using System;
using System.Collections.Generic;

#nullable disable

namespace Customer.Models
{
    public partial class ChiTietHoaDon
    {
        public int MaCt { get; set; }
        public int? MaHd { get; set; }
        public int? MaSp { get; set; }
        public int? SoLuong { get; set; }
        public decimal? Gia { get; set; }

        public virtual HoaDon MaHdNavigation { get; set; }
        public virtual MonAn MaSpNavigation { get; set; }
    }
}
