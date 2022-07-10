using System;
using System.Collections.Generic;

#nullable disable

namespace Customer.Models
{
    public partial class DanhGium
    {
        public int MaRv { get; set; }
        public int? MaSp { get; set; }
        public int? MaKh { get; set; }
        public DateTime? NgayReview { get; set; }
        public string Ndreview { get; set; }
        public string Writing { get; set; }

        public virtual User MaKhNavigation { get; set; }
        public virtual MonAn MaSpNavigation { get; set; }
    }
}
