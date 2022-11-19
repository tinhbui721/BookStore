namespace BookStore.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIACHI")]
    public partial class DIACHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIACHI()
        {
            HOADON = new HashSet<HOADON>();
        }

        [Key]
        public int MaDiaChi { get; set; }

        [StringLength(50)]
        public string TenNguoiNhan { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [Column("DiaChi")]
        [StringLength(100)]
        public string DiaChi1 { get; set; }

        [StringLength(50)]
        public string TenDangNhap { get; set; }

        public bool? MacDinh { get; set; }

        public string FullDiaChi => (TenNguoiNhan + ", " + SDT + ", " + DiaChi1);
        public virtual TAIKHOAN TAIKHOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADON { get; set; }
    }
}
