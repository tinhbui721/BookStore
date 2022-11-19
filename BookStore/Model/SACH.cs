namespace BookStore.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            CT_GIOHANG = new HashSet<CT_GIOHANG>();
            CT_HOADON = new HashSet<CT_HOADON>();
            DANHGIASACH = new HashSet<DANHGIASACH>();
            TAIKHOAN = new HashSet<TAIKHOAN>();
        }

        [Key]
        public int MaSach { get; set; }

        public int? MaLoaiSach { get; set; }

        [StringLength(100)]
        public string TenSach { get; set; }

        [StringLength(100)]
        public string TacGia { get; set; }

        public string NXB { get; set; }

        [Column(TypeName = "money")]
        public decimal? Gia { get; set; }

        public string MoTa { get; set; }

        [StringLength(200)]
        public string Hinh { get; set; }

        public int? GiamGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_GIOHANG> CT_GIOHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHGIASACH> DANHGIASACH { get; set; }

        public virtual LOAISACH LOAISACH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN> TAIKHOAN { get; set; }
    }
}
