namespace BookStore.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAOHANG")]
    public partial class GIAOHANG
    {
        [Key]
        [Column(TypeName = "money")]
        public decimal Gia { get; set; }
    }
}
