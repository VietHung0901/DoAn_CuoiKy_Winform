namespace DoAn_CuoiKy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            CT_DICHVU = new HashSet<CT_DICHVU>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDV { get; set; }

        [Required]
        [StringLength(200)]
        public string TenDV { get; set; }

        [Column(TypeName = "money")]
        public decimal Gia { get; set; }

        [Required]
        [StringLength(50)]
        public string DVT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DICHVU> CT_DICHVU { get; set; }
    }
}
