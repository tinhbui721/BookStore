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
    public partial class OrderDetail : Bunifu.UI.WinForms.BunifuUserControl
    {
        public OrderDetail()
        {
            InitializeComponent();
        }

        private void btnMuaLai_Click(object sender, EventArgs e)
        {
            var bookStoreView = ((OrderDetail)this).ParentForm;

            ((BookStoreView)bookStoreView).pages.SetPage("Book detail");
            ((BookStoreView)bookStoreView).LoadBooKDetailById(Int32.Parse(bookId.Text));
        }
    }
}
