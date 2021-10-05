using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LeThiThuTrang.Models
{
    public partial class LTQLDbContext:DbContext
    {
        public LTQLDbContext() : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LopHoc>()
            .Property(e => e.TenLop)
            .IsUnicode(false);
            modelBuilder.Entity<SinhVien>()
             .Property(e => e.MaSinhVien)
             .IsUnicode(false);

        }
    }
}