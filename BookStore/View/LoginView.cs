using BookStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            BookkStoreContext context = new BookkStoreContext();
            var res = context.TAIKHOAN.Where(x => x.TenDangNhap == lbTenDangNhap.Text && x.MatKhau == lbMatKhau.Text).ToList();
            if (res.Count() > 0)
            {
                this.Hide();
                BookStoreView bookStoreView = new BookStoreView();
                Global.userName = lbTenDangNhap.Text;
                bookStoreView.Owner = this;
                bookStoreView.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbMatKhau_TextChange(object sender, EventArgs e)
        {
            lbMatKhau.PasswordChar = '*';
        }
    }
}
