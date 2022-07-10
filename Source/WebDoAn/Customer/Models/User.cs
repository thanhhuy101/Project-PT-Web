using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Customer.Models
{
    public partial class User
    {
        public User()
        {
            DanhGia = new HashSet<DanhGium>();
        }

        public int MaKh { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string TenKh { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập phone")]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Vui lòng nhập đủ 10 số")]
        public int? Sdt { get; set; }

        public string GioiTinh { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string Matkhau { get; set; }

        public virtual ICollection<DanhGium> DanhGia { get; set; }
    }
}
