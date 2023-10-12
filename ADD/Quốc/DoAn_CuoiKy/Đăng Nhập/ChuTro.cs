namespace DoAn_CuoiKy.Đăng_Nhập
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuTro")]
    public partial class ChuTro
    {
        [Key]
        [StringLength(200)]
        public string TenDangNhap { get; set; }

        [StringLength(200)]
        public string MatKhau { get; set; }
    }
}
