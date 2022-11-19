namespace BookStore.View
{
    partial class DonHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.maDonHang = new System.Windows.Forms.Label();
            this.tinhTrangDonHang = new System.Windows.Forms.Label();
            this.hinhThucThanhToan = new System.Windows.Forms.Label();
            this.thoiGianGiaoHang = new System.Windows.Forms.Label();
            this.tongTien = new System.Windows.Forms.Label();
            this.mahoadon = new System.Windows.Forms.Label();
            this.btnXoaHuy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.title.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(21, 16);
            this.title.MaximumSize = new System.Drawing.Size(1100, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(849, 28);
            this.title.TabIndex = 7;
            this.title.Text = "THẦN THOẠI HY LẠP, TUYỂN TẬP NGUYỄN ĐÌNH CHIỂU và 1 Sản phẩm khác";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // maDonHang
            // 
            this.maDonHang.AutoSize = true;
            this.maDonHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maDonHang.Location = new System.Drawing.Point(23, 67);
            this.maDonHang.Name = "maDonHang";
            this.maDonHang.Size = new System.Drawing.Size(149, 28);
            this.maDonHang.TabIndex = 8;
            this.maDonHang.Text = "Mã đơn hàng: 2";
            // 
            // tinhTrangDonHang
            // 
            this.tinhTrangDonHang.AutoSize = true;
            this.tinhTrangDonHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTrangDonHang.Location = new System.Drawing.Point(541, 101);
            this.tinhTrangDonHang.Name = "tinhTrangDonHang";
            this.tinhTrangDonHang.Size = new System.Drawing.Size(342, 28);
            this.tinhTrangDonHang.TabIndex = 9;
            this.tinhTrangDonHang.Text = "Tình trạng đơn hàng: Đang giao hàng";
            // 
            // hinhThucThanhToan
            // 
            this.hinhThucThanhToan.AutoSize = true;
            this.hinhThucThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinhThucThanhToan.Location = new System.Drawing.Point(23, 101);
            this.hinhThucThanhToan.Name = "hinhThucThanhToan";
            this.hinhThucThanhToan.Size = new System.Drawing.Size(440, 28);
            this.hinhThucThanhToan.TabIndex = 11;
            this.hinhThucThanhToan.Text = "Hình thức thanh toán: Thanh toán khi nhận hàng";
            // 
            // thoiGianGiaoHang
            // 
            this.thoiGianGiaoHang.AutoSize = true;
            this.thoiGianGiaoHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoiGianGiaoHang.Location = new System.Drawing.Point(22, 134);
            this.thoiGianGiaoHang.Name = "thoiGianGiaoHang";
            this.thoiGianGiaoHang.Size = new System.Drawing.Size(474, 28);
            this.thoiGianGiaoHang.TabIndex = 12;
            this.thoiGianGiaoHang.Text = "Thời gian giao hàng dự kiến: 31/10/2022-5/11/2022";
            // 
            // tongTien
            // 
            this.tongTien.AutoSize = true;
            this.tongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongTien.ForeColor = System.Drawing.Color.Red;
            this.tongTien.Location = new System.Drawing.Point(541, 67);
            this.tongTien.Name = "tongTien";
            this.tongTien.Size = new System.Drawing.Size(187, 28);
            this.tongTien.TabIndex = 13;
            this.tongTien.Text = "Tổng tiền: 156000 đ";
            // 
            // mahoadon
            // 
            this.mahoadon.AutoSize = true;
            this.mahoadon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mahoadon.Location = new System.Drawing.Point(0, 0);
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.Size = new System.Drawing.Size(0, 28);
            this.mahoadon.TabIndex = 14;
            this.mahoadon.Visible = false;
            // 
            // btnXoaHuy
            // 
            this.btnXoaHuy.AutoSize = true;
            this.btnXoaHuy.BackColor = System.Drawing.Color.Red;
            this.btnXoaHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHuy.ForeColor = System.Drawing.Color.White;
            this.btnXoaHuy.Location = new System.Drawing.Point(999, 122);
            this.btnXoaHuy.MaximumSize = new System.Drawing.Size(100, 40);
            this.btnXoaHuy.MinimumSize = new System.Drawing.Size(100, 40);
            this.btnXoaHuy.Name = "btnXoaHuy";
            this.btnXoaHuy.Size = new System.Drawing.Size(100, 40);
            this.btnXoaHuy.TabIndex = 15;
            this.btnXoaHuy.Text = "Hủy";
            this.btnXoaHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoaHuy.Click += new System.EventHandler(this.btnXoaHuyDonHang_Click);
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderRadius = 10;
            this.Controls.Add(this.btnXoaHuy);
            this.Controls.Add(this.mahoadon);
            this.Controls.Add(this.tongTien);
            this.Controls.Add(this.thoiGianGiaoHang);
            this.Controls.Add(this.hinhThucThanhToan);
            this.Controls.Add(this.tinhTrangDonHang);
            this.Controls.Add(this.maDonHang);
            this.Controls.Add(this.title);
            this.Name = "DonHang";
            this.Size = new System.Drawing.Size(1136, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label maDonHang;
        public System.Windows.Forms.Label tinhTrangDonHang;
        public System.Windows.Forms.Label hinhThucThanhToan;
        public System.Windows.Forms.Label thoiGianGiaoHang;
        public System.Windows.Forms.Label tongTien;
        public System.Windows.Forms.Label mahoadon;
        public System.Windows.Forms.Label btnXoaHuy;
    }
}
