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
    public partial class TheLoai : Bunifu.UI.WinForms.BunifuUserControl
    {
        public TheLoai()
        {
            InitializeComponent();
        }

        public Image TheLoaiImage
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

        public string TheLoaiTitle
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

        public string TheLoaiId
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

        private void TheLoai_Click(object sender, EventArgs e)
        {
            var theLoaiId = ((TheLoai)sender).TheLoaiId;
            var bookStoreView = ((TheLoai)sender).ParentForm;
            ((BookStoreView)bookStoreView).pages.SetPage("Book list");
            ((BookStoreView)bookStoreView).LoadBooKListById(Int32.Parse(theLoaiId));

        }

        private void image_Click(object sender, EventArgs e)
        {
            TheLoai_Click(this, e);
        }

        private void title_Click(object sender, EventArgs e)
        {
            TheLoai_Click(this, e);
        }

    }
}
