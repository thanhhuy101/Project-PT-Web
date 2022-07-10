using System;
using System.Collections.Generic;

#nullable disable

namespace Customer.Models
{
    public partial class Category
    {
        public Category()
        {
            MonAns = new HashSet<MonAn>();
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }

        public virtual ICollection<MonAn> MonAns { get; set; }
    }
}
