namespace DoAn_CuoiKy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            PHIEUDANGKY = new HashSet<PHIEUDANGKY>();
            PHIEUPHAT = new HashSet<PHIEUPHAT>();
        }

        [Key]
        [StringLength(13)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        public long GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(200)]
        public string QueQuan { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDANGKY> PHIEUDANGKY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUPHAT> PHIEUPHAT { get; set; }
    }
}
