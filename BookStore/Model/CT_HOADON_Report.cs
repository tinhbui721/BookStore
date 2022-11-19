using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    internal class CT_HOADON_Report
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string Gia { get; set; }
        public int? GiamGia { get; set; }
        public int? SoLuong { get; set; }
        public string ThanhTien { get; set; }
        public byte[] Hinh { get; set; }
    }
}
