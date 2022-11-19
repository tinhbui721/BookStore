using BookStore.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class ReportView : Form
    {
        public static string[] s = { "\\bin" };
        public static string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0];
        public int donHangIdCurrent;

        public ReportView()
        {
            InitializeComponent();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {

            BookkStoreContext context = new BookkStoreContext();

            List<CT_HOADON> cT_HOADONs = context.CT_HOADON.Where(x => x.MaHoaDon == donHangIdCurrent).ToList();
            List<CT_HOADON_Report> cT_HOADON_Reports = new List<CT_HOADON_Report>();
            foreach(var item in cT_HOADONs)
            {
                CT_HOADON_Report cT_HOADON_Report = new CT_HOADON_Report();
                cT_HOADON_Report.MaSach = item.MaSach;
                cT_HOADON_Report.TenSach = item.SACH.TenSach;
                cT_HOADON_Report.Gia = item.Gia.ToString().Split('.')[0] + " đ";
                cT_HOADON_Report.Hinh = ImageToByteArray(Image.FromFile(path + item.SACH.Hinh));
                cT_HOADON_Report.SoLuong = item.SoLuong;
                cT_HOADON_Report.ThanhTien = item.ThanhTien.ToString().Split('.')[0] + " đ";

                cT_HOADON_Reports.Add(cT_HOADON_Report);
            }

            HOADON hOADON = context.HOADON.Find(donHangIdCurrent);
            List<HOADON_Report> hOADON_Reports = new List<HOADON_Report>();
            HOADON_Report hOADON_Report = new HOADON_Report();
            hOADON_Report.HinhThucGiao = hOADON.HinhThucGiao;
            hOADON_Report.HinhThucThanhToan = hOADON.HinhThucThanhToan;
            hOADON_Report.MaHoaDon = hOADON.MaHoaDon;
            hOADON_Report.NgayHoaDon = hOADON.NgayHoaDon.ToString("dd/MM/yyyy");
            hOADON_Report.PhiVanChuyen = hOADON.PhiVanChuyen.ToString().Split('.')[0] + " đ";
            hOADON_Report.TongTien = hOADON.TongTien.ToString().Split('.')[0] + " đ";
            hOADON_Report.DiaChi = hOADON.DIACHI.FullDiaChi;
            hOADON_Reports.Add(hOADON_Report);

            reportViewer.LocalReport.ReportPath = "./Report/HoaDonReport.rdlc";

            var source1 = new ReportDataSource("CT_HOADON_DataSet", cT_HOADON_Reports);
            var source2 = new ReportDataSource("HOADON_DataSet", hOADON_Reports);
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.EnableExternalImages = true;
            reportViewer.LocalReport.DataSources.Add(source1);
            reportViewer.LocalReport.DataSources.Add(source2);

            this.reportViewer.RefreshReport();
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
