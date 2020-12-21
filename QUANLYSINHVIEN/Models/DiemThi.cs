using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QUANLYSINHVIEN.Models
{
    public class DiemThi
    {
        [Key]
        [Required,MaxLength(50)]
        public string MaSv { get; set; }
        public string TenSv { get; set; }
        [Required, MaxLength(50)]
        public string MaMh { get; set; }
        public string TenMh { get; set; }
        public float Diem { get; set; }
        public SinhVien SinhVien { get; set; }
        public ICollection<MonHoc> MonHocs { get; set; }
    }
}