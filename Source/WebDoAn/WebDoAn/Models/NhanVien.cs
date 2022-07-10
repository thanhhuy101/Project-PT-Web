using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int MaAd { get; set; }
        public string TenAd { get; set; }
        public string TenTk { get; set; }
        public string Matkhau { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
