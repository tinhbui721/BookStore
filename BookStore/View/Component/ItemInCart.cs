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
    public partial class ItemInCart : Bunifu.UI.WinForms.BunifuUserControl
    {
        public ItemInCart()
        {
            InitializeComponent();
        }


        private void tang_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = Global.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_TangSoLuong";

                SqlParameter magiohang = new SqlParameter("@MaGioHang", SqlDbType.VarChar);
                magiohang.Value = maGioHang.Text;
                command.Parameters.Add(magiohang);


                SqlParameter sach = new SqlParameter("@MaSach", SqlDbType.Int);
                sach.Value = maSach.Text;
                command.Parameters.Add(sach);

                command.Connection = sqlConnection;
                command.ExecuteNonQuery();

                sqlConnection.Close();
            }

            var bookStoreView = ((ItemInCart)this).ParentForm;
            ((BookStoreView)bookStoreView).btnGioHang.PerformClick();
        }

        private void giam_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = Global.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_GiamSoLuong";

                SqlParameter magiohang = new SqlParameter("@MaGioHang", SqlDbType.VarChar);
                magiohang.Value = maGioHang.Text;
                command.Parameters.Add(magiohang);


                SqlParameter sach = new SqlParameter("@MaSach", SqlDbType.Int);
                sach.Value = maSach.Text;
                command.Parameters.Add(sach);

                command.Connection = sqlConnection;
                command.ExecuteNonQuery();

                sqlConnection.Close();
            }

            var bookStoreView = ((ItemInCart)this).ParentForm;
            ((BookStoreView)bookStoreView).btnGioHang.PerformClick();
        }


        private void btnCLick(object sender, EventArgs e)
        {
            var bookStoreView = ((ItemInCart)this).ParentForm;
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
                MaSach.Value = maSach.Text;
                command.Parameters.Add(MaSach);

                command.Connection = sqlConnection;
                command.ExecuteNonQuery();

                sqlConnection.Close();
            }

            ((BookStoreView)bookStoreView).pages.SetPage("Book detail");
            ((BookStoreView)bookStoreView).LoadBooKDetailById(Int32.Parse(maSach.Text));
        }
    }
}
