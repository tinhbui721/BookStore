namespace BookStore.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIOHANG")]
    public partial class GIOHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIOHANG()
        {
            CT_GIOHANG = new HashSet<CT_GIOHANG>();
        }

        [Key]
        public int MaGioHang { get; set; }

        [StringLength(50)]
        public string TenDangNhap { get; set; }

        public bool? DaDungMaGiamGia { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_GIOHANG> CT_GIOHANG { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
