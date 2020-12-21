using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QUANLYSINHVIEN.Models
{
    public class Lop
    {
        [Key]
        [Required,MaxLength(50)]
        public string MaLop { get; set; }
        [Required, MaxLength(50)]
        public string TenLop { get; set; }
        [Required, MaxLength(50)]
        public string MaKhoa { get; set; }
        public SinhVien SinhVien { get; set; }
        public ICollection<Khoa> Khoas { get; set; }
   
    }
}