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
    public partial class DonHang : Bunifu.UI.WinForms.BunifuUserControl
    {
        public DonHang()
        {
            InitializeComponent();
        }

        private void btnXoaHuyDonHang_Click(object sender, EventArgs e)
        {

            var respone = MessageBox.Show("Bạn có chắc muốn " + btnXoaHuy.Text + " đơn hàng này?" , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(respone == DialogResult.Yes)
            {
                using (SqlConnection sqlConnection = Global.GetSqlConnection())
                {
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_XoaChiTietHoaDon";

                    SqlParameter MaHoaDon = new SqlParameter("@MaHoaDon", SqlDbType.Int);
                    MaHoaDon.Value = mahoadon.Text;
                    command.Parameters.Add(MaHoaDon);

                    command.Connection = sqlConnection;
                    command.ExecuteNonQuery();

                    sqlConnection.Close();
                }
                MessageBox.Show("Đã " + btnXoaHuy.Text + " đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var bookStoreView = ((DonHang)this).ParentForm;

                ((BookStoreView)bookStoreView).pages.SetPage("Đơn hàng");
                ((BookStoreView)bookStoreView).LoadDonHang();
            }

        }

        private void title_Click(object sender, EventArgs e)
        {
            var bookStoreView = ((DonHang)this).ParentForm;

            ((BookStoreView)bookStoreView).pages.SetPage("Order detail");
            ((BookStoreView)bookStoreView).LayChiTietDonHang(Int32.Parse(mahoadon.Text));
        }
    }
}
