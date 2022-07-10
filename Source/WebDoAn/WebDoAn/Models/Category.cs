using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Admin.Models
{
    public partial class Category
    {
        public Category()
        {
            MonAns = new HashSet<MonAn>();
        }

        public int MaLoai { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên loại!!!")]
        public string TenLoai { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả!!!!")]
        public string MoTa { get; set; }

        public virtual ICollection<MonAn> MonAns { get; set; }
    }
}
