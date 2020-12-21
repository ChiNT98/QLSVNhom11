using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QUANLYSINHVIEN.Models
{
    public class MonHoc
    {
        [Key]
        [Required,MaxLength(50)]
        public string MaMh { get; set; }
        [Required, MaxLength(50)]
        public string TenMh { get; set; }
        public string TenGv { get; set; }
        public float SoTc { get; set; }
        public DiemThi DiemThi { get; set; }
    }
}