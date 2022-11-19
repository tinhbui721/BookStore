namespace BookStore.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CT_HOADON = new HashSet<CT_HOADON>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        [StringLength(50)]
        public string TenDangNhap { get; set; }

        public DateTime NgayHoaDon { get; set; }

        public DateTime? NgayGiaoHangMin { get; set; }

        public DateTime? NgayGiaoHangMax { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [StringLength(50)]
        public string HinhThucGiao { get; set; }

        [StringLength(50)]
        public string HinhThucThanhToan { get; set; }

        public int? MaDiaChi { get; set; }

        public bool? TinhTrang { get; set; }

        [Column(TypeName = "money")]
        public decimal? PhiVanChuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }

        public virtual DIACHI DIACHI { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
