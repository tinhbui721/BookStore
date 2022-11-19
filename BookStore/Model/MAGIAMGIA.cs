namespace BookStore.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MAGIAMGIA")]
    public partial class MAGIAMGIA
    {
        [Key]
        [Column("MaGiamGia")]
        [StringLength(5)]
        public string MaGiamGia1 { get; set; }

        public int? TiLeGiam { get; set; }
    }
}
