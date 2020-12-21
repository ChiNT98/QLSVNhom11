using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QUANLYSINHVIEN.Models
{
    public class SinhVien
    {
        [Key]
        [Required,MaxLength(50)]
        public string MaSv { get; set; }
        [Required, MaxLength(50)]
        public string TenSv { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        [Required, MaxLength(50)]
        public string MaLop { get; set; }
        [Required, MaxLength(50)]
        public string MaKhoa { get; set; }

        internal static SinhVien Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        [Required, MaxLength(12),MinLength(10)]
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public ICollection<Lop> Lops { get; set; }
        public ICollection<DiemThi> DiemThis { get; set; }


    }
}