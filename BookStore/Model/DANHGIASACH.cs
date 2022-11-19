namespace BookStore.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHGIASACH")]
    public partial class DANHGIASACH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSach { get; set; }

        [StringLength(500)]
        public string NoiDung { get; set; }

        public int? DanhGia { get; set; }

        public DateTime? NgayDanhGia { get; set; }

        public virtual SACH SACH { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
