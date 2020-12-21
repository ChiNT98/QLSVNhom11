using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QUANLYSINHVIEN.Models
{
    public partial class DBConnect : DbContext
    {
        public virtual DbSet<DiemThi> DiemThis { get; set; }
        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<accout> Accouts { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public DBConnect()
            : base("name=DBConntext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
