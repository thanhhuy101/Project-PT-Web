using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Customer.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int MaHd { get; set; }
        public int? MaSp { get; set; }
        public int? MaAd { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string TenKh { get; set; }
        public string TenSp { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập phone")]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Vui lòng nhập đủ 10 số")]
        public int? Sdt { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string DiaChi { get; set; }
        public decimal? GiaSp { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn ngày lập")]
        public DateTime? NgayLap { get; set; }
        public int? TongSoLuong { get; set; }
        public decimal? TongTien { get; set; }

        public virtual NhanVien MaAdNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
