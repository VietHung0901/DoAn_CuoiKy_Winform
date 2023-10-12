using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn_CuoiKy.Đăng_Nhập
{
    public partial class HeThongDangNhapDB : DbContext
    {
        public HeThongDangNhapDB()
            : base("name=HeThongDangNhapDB")
        {
        }

        public virtual DbSet<ChuTro> ChuTroes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
