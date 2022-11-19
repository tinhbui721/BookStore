using BookStore.Model;
using BookStore.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookStore
{
    public partial class BookStoreView : Form
    {
        public static string[] s = { "\\bin" };
        public static string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0];
        public int theLoaiIdCurrent;
        public int sachIdCurrent;
        public int donHangIdCurrent;
        public int maGioHangIdCurrent;
        public BookStoreView()
        {
            InitializeComponent();
            LoadDataForSearch();
        }

        private void LoadDataForSearch()
        {
            BookkStoreContext context = new BookkStoreContext();
            txtSearch.AutoCompleteCustomSource.AddRange(context.SACH.Select(x => x.TenSach).ToList().ToArray());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            BookkStoreContext context = new BookkStoreContext();
            var theLoai = context.LOAISACH.ToList();

            lbName.Text = context.TAIKHOAN.Where(x => x.TenDangNhap == Global.userName).FirstOrDefault().TenKhachHang;

            foreach (var item in theLoai)
            {
                TheLoai a = new TheLoai();
                a.Margin = new Padding(15, 15, 15, 15);
                a.TheLoaiImage = Image.FromFile(path + item.Hinh);
                a.TheLoaiTitle = item.TenLoaiSach;
                a.TheLoaiId = item.MaLoaiSach.ToString();
                flowLayoutPanel.Controls.Add(a);
            }
        }

        public void LoadBooKListById(int id)
        {
            BookkStoreContext context = new BookkStoreContext();
            flowLayoutPanelBook.Controls.Clear();
            var books = context.SACH.Where(x => x.MaLoaiSach == id).ToList();
            theLoaiIdCurrent = id;
            foreach (var item in books)
            {
                Sach a = new Sach();
                a.Margin = new Padding(15, 15, 15, 15);
                a.BookImage = Image.FromFile(path + item.Hinh);
                a.BookTitle = item.TenSach;
                a.Gia = item.Gia.ToString().Split('.')[0] + " đ";
                a.GiaGiam = (item.Gia - item.Gia * item.GiamGia / 100).ToString().Split('.')[0] + " đ";
                a.SachId = item.MaSach.ToString();
                flowLayoutPanelBook.Controls.Add(a);
            }
        }

        public void LoadBooKDetailById(int id)
        {
            BookkStoreContext context = new BookkStoreContext();
            flowLayoutPanelComment.Controls.Clear();
            var rating = 0;
            var book = context.SACH.Where(x => x.MaSach == id).FirstOrDefault();
            var comments = context.DANHGIASACH.Where(x => x.MaSach == id).ToList();
            sachIdCurrent = id;
            bookImage.Image = Image.FromFile(path + book.Hinh);
            title.Text = book.TenSach;
            price.Text = book.Gia.ToString().Split('.')[0] + " đ";
            priceDiscount.Text = (book.Gia - book.Gia * book.GiamGia / 100).ToString().Split('.')[0] + " đ";
            tacGia.Text = "Tác giả: " + book.TacGia;
            nxb.Text = "NXB: " + book.NXB;
            theloai.Text = "Thể loại: " + book.LOAISACH.TenLoaiSach;
            mota.Text = book.MoTa;

            foreach (var comment in comments)
            {
                Comment a = new Comment();
                a.UserName = comment.TAIKHOAN.TenKhachHang;
                a.Date = comment.NgayDanhGia.ToString();
                a.Content = comment.NoiDung;
                a.Rate = (int)comment.DanhGia;
                rating += (int)comment.DanhGia;
                if (comment.TenDangNhap != Global.userName)
                {
                    a.btnXoaComment.Visible = false;
                }
                else
                {
                    a.btnXoaComment.Visible = true;
                }
                flowLayoutPanelComment.Controls.Add(a);
            }
            if (rating != 0)
            {
                totalRating.Visible = true;
                totalRating.Value = (int)Math.Round((float)rating / comments.Count);
            }
            else
                totalRating.Visible = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Text);
            Global.curentPage = pages.PageTitle;
            switch (((Control)sender).Text)
            {
                case "Giỏ hàng":
                    LoadGioHang();
                    break;

                case "Đã xem":
                    LoadBookDaXem();
                    break;

                case "Đơn hàng":
                    LoadDonHang();
                    break;
            }
        }

        private string GetTitleDonHang(int mahoadon)
        {
            string title = "";
            BookkStoreContext context = new BookkStoreContext();
            var cthd = context.CT_HOADON.Where(x => x.MaHoaDon == mahoadon).ToList();
            foreach (var item in cthd)
            {
                if (title == "")
                    title = item.SACH.TenSach;
                else
                    title = title + ", " + item.SACH.TenSach;
            }
            return title;
        }

        public void LoadDonHang()
        {
            flowLayoutPanelDonHang.Controls.Clear();
            using (SqlConnection sqlConnection = Global.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_LayHoaDonTheoTenDangNhap";

                SqlParameter TenDangNhap = new SqlParameter("@TenDangNhap", SqlDbType.VarChar);
                TenDangNhap.Value = Global.userName;
                command.Parameters.Add(TenDangNhap);

                command.Connection = sqlConnection;
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    DonHang a = new DonHang();
                    a.mahoadon.Text = result.GetInt32(0).ToString();
                    a.Margin = new Padding(5);
                    a.maDonHang.Text = "Mã đơn hàng: " + result.GetInt32(0).ToString();
                    a.hinhThucThanhToan.Text = "Hình thức thanh toán: " + result.GetString(7);
                    a.tinhTrangDonHang.Text = "Tình trạng đơn hàng: " + (result.GetBoolean(9) ? "Đã giao hàng" : "Đang giao hàng");
                    a.tongTien.Text = "Tổng tiền: " + (result.GetDecimal(5)).ToString().Split('.')[0] + " đ";
                    a.thoiGianGiaoHang.Text = "Thời gian giao hàng dự kiến: " + result.GetDateTime(3).ToString("dd/MM/yyyy") + " - " + result.GetDateTime(4).ToString("dd/MM/yyyy");
                    a.title.Text = GetTitleDonHang(result.GetInt32(0));
                    if (result.GetBoolean(9) == false)
                    {
                        a.btnXoaHuy.Text = "Hủy";
                    }
                    else
                    {
                        a.btnXoaHuy.Text = "Xóa";
                    }
                    flowLayoutPanelDonHang.Controls.Add(a);
                }
                sqlConnection.Close();
            }
        }

        public void LayChiTietDonHang(int mahoadon)
        {
            donHangIdCurrent = mahoadon;
            flowLayoutOrderDetail.Controls.Clear();
            using (SqlConnection sqlConnection = Global.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_LayChiTietHoaDon";

                SqlParameter MaHodDon = new SqlParameter("@MaHoaDon", SqlDbType.Int);
                MaHodDon.Value = mahoadon;
                command.Parameters.Add(MaHodDon);

                command.Connection = sqlConnection;
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    OrderDetail a = new OrderDetail();
                    a.Margin = new Padding(5);
                    a.image.Image = Image.FromFile(path + result.GetString(9));
                    a.title.Text = result.GetString(10);
                    a.price.Text = (result.GetDecimal(11)).ToString().Split('.')[0] + " đ";
                    a.quantity.Text = result.GetInt32(12).ToString();
                    a.thanhtien.Text = (result.GetDecimal(13)).ToString().Split('.')[0] + " đ";
                    a.bookId.Text = result.GetInt32(1).ToString();

                    flowLayoutOrderDetail.Controls.Add(a);

                    maDonHang.Text = result.GetInt32(0).ToString();
                    hinhthucvanchuyen.Text = result.GetString(7);
                    hinhthucthanhtoan.Text = result.GetString(8);
                    tinhtrangdonhang.Text = result.GetBoolean(2) ? "Đã giao hàng" : "Đang giao hàng";
                    hoten.Text = result.GetString(3);
                    sdt.Text = result.GetString(4);
                    diachi.Text = "Địa chỉ: " + result.GetString(5);
                    phigiaohang.Text = (result.GetDecimal(14)).ToString().Split('.')[0] + " đ";
                    totalPrice.Text = (result.GetDecimal(15)).ToString().Split('.')[0] + " đ";
                    dateOrder.Text = result.GetDateTime(6).ToString("dd/MM/yyyy");
                }
                sqlConnection.Close();
            }
        }


        public void LoadThongTinDatHang()
        {
            flowLayoutPanelDatHang.Controls.Clear();
            BookkStoreContext context = new BookkStoreContext();

            dh_PhiGiaoHang.Text = context.GIAOHANG.FirstOrDefault().Gia.ToString().Split('.')[0] + " đ";

            List<DIACHI> listDC = new List<DIACHI>();
            listDC = context.DIACHI.Where(x => x.TenDangNhap == Global.userName).ToList();

            dh_DiaChiNguoiNhan.DisplayMember = "FullDiaChi";
            dh_DiaChiNguoiNhan.ValueMember = "MaDiaChi";

            dh_DiaChiNguoiNhan.DataSource = listDC;

            using (SqlConnection sqlConnection = Global.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_LayThongTinGioHang";

                SqlParameter tendangnhap = new SqlParameter("@TenDangNhap", SqlDbType.VarChar);
                tendangnhap.Value = Global.userName;
                command.Parameters.Add(tendangnhap);

                command.Connection = sqlConnection;
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    OrderDetail a = new OrderDetail();
                    a.Margin = new Padding(10);
                    a.image.Image = Image.FromFile(path + result.GetString(3));
                    a.title.Text = result.GetString(0);
                    a.quantity.Text = result.GetInt32(2).ToString();
                    a.price.Text = (result.GetDecimal(7) - result.GetDecimal(7) * result.GetInt32(8) / 100).ToString().Split('.')[0] + " đ";
                    a.thanhtien.Text = result.GetDecimal(1).ToString().Split('.')[0] + " đ";
                    a.bookId.Text = result.GetInt32(6).ToString();
                    a.btnMuaLai.Visible = false;
                    dh_TongTien.Text = result.GetDecimal(4).ToString().Split('.')[0] + " đ";
                    flowLayoutPanelDatHang.Controls.Add(a);
                }
                sqlConnection.Close();
            }
        }


        public void LoadBookDaXem()
        {
            flowLayoutPanelSachDaXem.Controls.Clear();
            using (SqlConnection sqlConnection = Global.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_LayThongTinSPDaXem";

                SqlParameter TenDangNhap = new SqlParameter("@TenDangNhap", SqlDbType.VarChar);
                TenDangNhap.Value = Global.userName;
                command.Parameters.Add(TenDangNhap);

                command.Connection = sqlConnection;
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    Sach a = new Sach();
                    a.Margin = new Padding(15);
                    a.BookTitle = result.GetString(2);
                    a.BookImage = Image.FromFile(path + result.GetString(6));
                    a.Gia = result.GetDecimal(4).ToString().Split('.')[0] + " đ";
                    a.GiaGiam = (result.GetDecimal(4) - result.GetDecimal(4) * result.GetInt32(5) / 100).ToString().Split('.')[0] + " đ";
                    a.SachId = result.GetInt32(0).ToString();
                    flowLayoutPanelSachDaXem.Controls.Add(a);
                }
                sqlConnection.Close();
            }
        }

        public void LoadGioHang()
        {
            flowLayoutPanelGioHang.Controls.Clear();
            using (SqlConnection sqlConnection = Global.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_LayThongTinGioHang";

                SqlParameter tendangnhap = new SqlParameter("@TenDangNhap", SqlDbType.VarChar);
                tendangnhap.Value = Global.userName;
                command.Parameters.Add(tendangnhap);

                command.Connection = sqlConnection;
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    ItemInCart a = new ItemInCart();
                    a.Margin = new Padding(10);
                    a.image.Image = Image.FromFile(path + result.GetString(3));
                    a.title.Text = result.GetString(0);
                    a.price.Text = result.GetDecimal(7).ToString().Split('.')[0] + " đ";
                    a.priceDiscount.Text = (result.GetDecimal(7) - result.GetDecimal(7) * result.GetInt32(8) / 100).ToString().Split('.')[0] + " đ";
                    a.thanhtien.Text = result.GetDecimal(1).ToString().Split('.')[0] + " đ";
                    a.soluong.Text = result.GetInt32(2).ToString();
                    a.maGioHang.Text = result.GetInt32(5).ToString();
                    a.maSach.Text = result.GetInt32(6).ToString();
                    tongTien.Text = result.GetDecimal(4).ToString().Split('.')[0] + " đ";
                    maGioHangIdCurrent = result.GetInt32(5);
                    flowLayoutPanelGioHang.Controls.Add(a);

                }
                sqlConnection.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {

            switch (Global.curentPage)
            {
                case "Trang chủ":
                    pages.SetPage("Book list");
                    LoadBooKListById(theLoaiIdCurrent);
                    break;

                case "Đã xem":
                    pages.SetPage("Đã xem");
                    LoadBookDaXem();
                    break;

                case "Giỏ hàng":
                    pages.SetPage("Giỏ hàng");
                    LoadGioHang();
                    break;

                case "Đơn hàng":
                    pages.SetPage("Order detail");
                    LayChiTietDonHang(donHangIdCurrent);
                    break;

                case "Search result":
                    pages.SetPage("Search result");
                    LoadDataForSearch();
                    break;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BookkStoreContext context = new BookkStoreContext();
            try
            {
                if (context.DANHGIASACH.Where(x => x.MaSach == sachIdCurrent && x.TenDangNhap == Global.userName).ToList().Count() > 0)
                {
                    MessageBox.Show("Bạn đã đánh giá cho xách này rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DANHGIASACH dANHGIASACH = new DANHGIASACH();
                    dANHGIASACH.MaSach = sachIdCurrent;
                    dANHGIASACH.TenDangNhap = Global.userName;
                    dANHGIASACH.NgayDanhGia = DateTime.Now;
                    dANHGIASACH.NoiDung = commentContent.Text;
                    dANHGIASACH.DanhGia = commentRating.Value;
                    context.DANHGIASACH.Add(dANHGIASACH);
                    context.SaveChanges();
                    MessageBox.Show("Thêm đánh giá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            commentContent.Text = "";
            LoadBooKDetailById(sachIdCurrent);
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = Global.GetSqlConnection())
                {
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_ThemSachVaoGioHang";

                    SqlParameter tendangnhap = new SqlParameter("@TenDangNhap", SqlDbType.VarChar);
                    tendangnhap.Value = Global.userName;
                    command.Parameters.Add(tendangnhap);

                    SqlParameter sach = new SqlParameter("@MaSach", SqlDbType.Int);
                    sach.Value = sachIdCurrent;
                    command.Parameters.Add(sach);

                    command.Connection = sqlConnection;
                    command.ExecuteNonQuery();

                    sqlConnection.Close();
                }
                MessageBox.Show("Đã thêm sách vào giỏ hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Bạn đã thêm sản này vào giỏ hàng rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApMaGiamGia_Click(object sender, EventArgs e)
        {
            var tongTienTruoc = tongTien.Text;
            using (SqlConnection sqlConnection = Global.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_ApDungMa";

                SqlParameter magiamgia = new SqlParameter("@MaGiamGia", SqlDbType.VarChar);
                magiamgia.Value = maGiamGia.Text;
                command.Parameters.Add(magiamgia);

                SqlParameter magiohang = new SqlParameter("@MaGioHang", SqlDbType.Int);
                magiohang.Value = maGioHangIdCurrent;
                command.Parameters.Add(magiohang);

                command.Connection = sqlConnection;
                command.ExecuteNonQuery();

                LoadGioHang();

                sqlConnection.Close();

                if (tongTien.Text == tongTienTruoc)
                {
                    MessageBox.Show("Bạn đã dùng mã giảm giá rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đã áp mã giảm giá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            pages.SetPage("Đặt hàng");
            LoadThongTinDatHang();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pages.SetPage("Trang chủ");
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = Global.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_ThemHoaDon";

                SqlParameter TenDangNhap = new SqlParameter("@TenDangNhap", SqlDbType.VarChar);
                TenDangNhap.Value = Global.userName;
                command.Parameters.Add(TenDangNhap);

                SqlParameter NgayHoaDon = new SqlParameter("@NgayHoaDon", SqlDbType.DateTime);
                NgayHoaDon.Value = DateTime.Now;
                command.Parameters.Add(NgayHoaDon);

                SqlParameter NgayGiaoHangMin = new SqlParameter("@NgayGiaoHangMin", SqlDbType.DateTime);
                NgayGiaoHangMin.Value = DateTime.Now.AddDays(5);
                command.Parameters.Add(NgayGiaoHangMin);

                SqlParameter NgayGiaoHangMax = new SqlParameter("@NgayGiaoHangMax", SqlDbType.DateTime);
                NgayGiaoHangMax.Value = DateTime.Now.AddDays(10);
                command.Parameters.Add(NgayGiaoHangMax);

                SqlParameter MaDiaChi = new SqlParameter("@MaDiaChi", SqlDbType.Int);
                MaDiaChi.Value = ((DIACHI)(dh_DiaChiNguoiNhan.SelectedItem)).MaDiaChi;
                command.Parameters.Add(MaDiaChi);

                command.Connection = sqlConnection;
                command.ExecuteNonQuery();

                LoadGioHang();

                sqlConnection.Close();
            }
            MessageBox.Show("Đã tạo đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pages.SetPage("Giỏ hàng");
            tongTien.Text = "0 đ";
            LoadGioHang();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                LoginView loginView = new LoginView();
                loginView.Show();
                this.Hide();
            }
        }

        private void txtSearch_OnIconRightClick(object sender, EventArgs e)
        {
            flowLayoutSearchResult.Controls.Clear();
            BookkStoreContext context = new BookkStoreContext();
            var searchValue = txtSearch.Text.ToUpper();

            var result = context.SACH.Where(x => x.TenSach.ToUpper().Contains(searchValue) || x.MoTa.ToUpper().Contains(searchValue)).ToList();
            foreach (var item in result)
            {
                Sach a = new Sach();
                a.Margin = new Padding(15, 15, 15, 15);
                a.BookImage = Image.FromFile(path + item.Hinh);
                a.BookTitle = item.TenSach;
                a.Gia = item.Gia.ToString().Split('.')[0] + " đ";
                a.GiaGiam = (item.Gia - item.Gia * item.GiamGia / 100).ToString().Split('.')[0] + " đ";
                a.SachId = item.MaSach.ToString();
                flowLayoutSearchResult.Controls.Add(a);
            }
            pages.SetPage("Search result");
            Global.curentPage = pages.PageTitle;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSearch_OnIconRightClick(sender, e);
            }
        }

        private void BookStoreView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportView reportView = new ReportView();
            reportView.donHangIdCurrent = Int32.Parse(maDonHang.Text);
            reportView.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            BookkStoreContext context = new BookkStoreContext();
            flowLayoutPanelBook.Controls.Clear();
            var giamin = 0;
            var giamax = 1000000000;

            switch (dropLocTheoGia.SelectedItem)
            {
                case "Tất cả":
                    giamin = 0;
                    giamax = 1000000000;
                    break;
                case "<50000":
                    giamax = 50000;
                    break;

                case "50000 - 100000":
                    giamin = 50000;
                    giamax = 100000;
                    break;

                case "100000 - 200000":
                    giamin = 100000;
                    giamax = 200000;
                    break;
                case ">200000":
                    giamin = 200000;
                    break;
            }

            var giamgiamin = 0;
            var giamgiamax = 100;
            switch (dropLocTheoPhanTram.SelectedItem)
            {
                case "Tất cả":
                    giamgiamin = 0;
                    giamgiamax = 100;
                    break;
                case "<5%":
                    giamgiamax = 5;
                    break;

                case "5% - 10%":
                    giamgiamin = 5;
                    giamgiamax = 10;
                    break;

                case "10% - 20%":
                    giamgiamin = 10;
                    giamgiamax = 20;
                    break;
                case ">20%":
                    giamgiamin = 20;
                    break;
            }


            var books = context.SACH.Where(x => x.MaLoaiSach == theLoaiIdCurrent
                                && (x.Gia - x.Gia * x.GiamGia / 100) > giamin
                                && (x.Gia - x.Gia * x.GiamGia / 100) < giamax
                                && x.GiamGia >= giamgiamin
                                && x.GiamGia <= giamgiamax).ToList();

            foreach (var item in books)
            {
                Sach a = new Sach();
                a.Margin = new Padding(15, 15, 15, 15);
                a.BookImage = Image.FromFile(path + item.Hinh);
                a.BookTitle = item.TenSach;
                a.Gia = item.Gia.ToString().Split('.')[0] + " đ";
                a.GiaGiam = (item.Gia - item.Gia * item.GiamGia / 100).ToString().Split('.')[0] + " đ";
                a.SachId = item.MaSach.ToString();
                flowLayoutPanelBook.Controls.Add(a);
            }
        }
    }
}
