using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QUANLYSINHVIEN.Models
{
    public class accout
    {
        [Key]
        public string Email { get; set; }
        [Required(ErrorMessage ="Tên Đăng Nhập Là Bắt Buộc")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [StringLength(20)]
        public string RoleID { get; set; }
    }
}