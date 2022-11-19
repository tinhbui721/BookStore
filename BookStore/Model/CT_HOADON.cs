namespace BookStore.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HOADON
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSach { get; set; }

        public int? SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        [Column(TypeName = "money")]
        public decimal? Gia { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
