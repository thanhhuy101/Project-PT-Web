using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Customer.Models
{
    public partial class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập phone")]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Vui lòng nhập đủ 10 số")]
        public string Sdt { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Contents { get; set; }
    }
}
