using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QUANLYSINHVIEN.Models
{
    public class GiangVien
    {
        [Key]
        [Required, MaxLength(50)]
        public string MaGv { get; set; }
        [Required, MaxLength(50)]
        public string TenGv { get; set; }
        [Required, MaxLength(50)]
        public string MaKhoa { get; set; }
        [Required, MaxLength(50)]
        public string MaLop { get; set; }
        public Khoa Khoa { get; set; }
    }
}