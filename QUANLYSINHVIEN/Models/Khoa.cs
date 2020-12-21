using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QUANLYSINHVIEN.Models
{
    public class Khoa
    {
        [Key]
        [Required,MaxLength(50)]
        public string MaKhoa { get; set; }
        [Required, MaxLength(50)]
        public string TenKhoa { get; set; }
        public Lop Lop { get; set; }
        public ICollection<GiangVien> GiangViens { get; set; }
    }
}