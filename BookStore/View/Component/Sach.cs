using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.View
{
    public partial class Sach : Bunifu.UI.WinForms.BunifuUserControl
    {
        public Sach()
        {
            InitializeComponent();
        }

        public Image BookImage
        {
            get
            {
                return image.Image;
            }

            set
            {
                image.Image = value;
            }
        }

        public string BookTitle
        {
            get
            {
                return title.Text;
            }

            set
            {
                title.Text = value;
            }
        }

        public string Gia
        {
            get
            {
                return price.Text;
            }

            set
            {
                price.Text = value;

            }
        }

        public string GiaGiam
        {
            get
            {
                return priceDiscount.Text;
            }

            set
            {
                priceDiscount.Text = value;
            }
        }

        public string SachId
        {
            get
            {
                return id.Text;
            }

            set
            {
                id.Text = value;
            }
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
                    sach.Value = id.Text;
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

        private void Sach_Click(object sender, EventArgs e)
        {
            var sachId = ((Sach)sender).SachId;
            var bookStoreView = ((Sach)sender).ParentForm;

            using (SqlConnection sqlConnection = Global.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_ThemSachDaXem";

                SqlParameter TenDangNhap = new SqlParameter("@TenDangNhap", SqlDbType.VarChar);
                TenDangNhap.Value = Global.userName;
                command.Parameters.Add(TenDangNhap);

                SqlParameter MaSach = new SqlParameter("@MaSach", SqlDbType.Int);
                MaSach.Value = id.Text;
                command.Parameters.Add(MaSach);

                command.Connection = sqlConnection;
                command.ExecuteNonQuery();

                sqlConnection.Close();
            }

            ((BookStoreView)bookStoreView).pages.SetPage("Book detail");
            ((BookStoreView)bookStoreView).LoadBooKDetailById(Int32.Parse(sachId));



        }

        private void image_Click(object sender, EventArgs e)
        {
            Sach_Click(this, e);
        }

        private void title_Click(object sender, EventArgs e)
        {
            Sach_Click(this, e);
        }
    }
}
