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
    public partial class Comment : Bunifu.UI.WinForms.BunifuUserControl
    {
        BookkStoreContext context = new BookkStoreContext();
        public Comment()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get
            {
                return userName.Text;
            }

            set
            {
                userName.Text = value;
            }
        }

        public string Content
        {
            get
            {
                return content.Text;
            }

            set
            {
                content.Text = value;
            }
        }

        public string Date
        {
            get
            {
                return date.Text;
            }

            set
            {
                date.Text = value;
            }
        }

        public int Rate
        {
            get
            {
                return rate.Value;
            }

            set
            {
                rate.Value = value;
            }
        }

        private void btnXoaComment_Click(object sender, EventArgs e)
        {
            var respone = MessageBox.Show("Bạn có chắc muốn xóa đánh giá này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respone == DialogResult.Yes)
            {
                var bookStoreView = ((Comment)this).ParentForm;
                DANHGIASACH dANHGIASACH = context.DANHGIASACH.Where(x => x.TenDangNhap == Global.userName && x.MaSach == ((BookStoreView)bookStoreView).sachIdCurrent).FirstOrDefault();
                context.DANHGIASACH.Remove(dANHGIASACH);
                context.SaveChanges();
                MessageBox.Show("Đã xóa đánh giá của bạn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((BookStoreView)bookStoreView).LoadBooKDetailById(((BookStoreView)bookStoreView).sachIdCurrent);
            }
        }
    }
}
