using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class MonAn
    {
        public MonAn()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            DanhGia = new HashSet<DanhGium>();
            GioHangs = new HashSet<GioHang>();
        }

        public int MaSp { get; set; }
        public int? MaLoai { get; set; }
        public string TenSp { get; set; }
        public string HinhAnh { get; set; }
        public decimal? GiaSp { get; set; }
        public string MoTa { get; set; }

        public virtual Category MaLoaiNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual ICollection<DanhGium> DanhGia { get; set; }
        public virtual ICollection<GioHang> GioHangs { get; set; }
    }
}
