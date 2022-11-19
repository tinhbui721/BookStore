namespace BookStore.View
{
    partial class ItemInCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemInCart));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.image = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.priceDiscount = new System.Windows.Forms.Label();
            this.soluong = new Bunifu.UI.WinForms.BunifuTextBox();
            this.thanhtien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maGioHang = new System.Windows.Forms.Label();
            this.maSach = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(17, 14);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(131, 190);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.btnCLick);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.title.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(168, 23);
            this.title.MaximumSize = new System.Drawing.Size(450, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(300, 35);
            this.title.TabIndex = 6;
            this.title.Text = "THẦN THOẠI HY LẠP";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Click += new System.EventHandler(this.btnCLick);
            // 
            // price
            // 
            this.price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.price.AutoSize = true;
            this.price.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.price.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.DarkGray;
            this.price.Location = new System.Drawing.Point(167, 82);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(84, 28);
            this.price.TabIndex = 8;
            this.price.Text = "150000";
            this.price.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // priceDiscount
            // 
            this.priceDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceDiscount.AutoSize = true;
            this.priceDiscount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.priceDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceDiscount.ForeColor = System.Drawing.Color.Red;
            this.priceDiscount.Location = new System.Drawing.Point(167, 110);
            this.priceDiscount.Name = "priceDiscount";
            this.priceDiscount.Size = new System.Drawing.Size(84, 28);
            this.priceDiscount.TabIndex = 7;
            this.priceDiscount.Text = "150000";
            this.priceDiscount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // soluong
            // 
            this.soluong.AcceptsReturn = false;
            this.soluong.AcceptsTab = false;
            this.soluong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soluong.AnimationSpeed = 200;
            this.soluong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.soluong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.soluong.BackColor = System.Drawing.Color.Transparent;
            this.soluong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soluong.BackgroundImage")));
            this.soluong.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.soluong.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.soluong.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.soluong.BorderColorIdle = System.Drawing.Color.Silver;
            this.soluong.BorderRadius = 1;
            this.soluong.BorderThickness = 1;
            this.soluong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.soluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soluong.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.soluong.DefaultText = "0";
            this.soluong.FillColor = System.Drawing.Color.White;
            this.soluong.HideSelection = true;
            this.soluong.IconLeft = null;
            this.soluong.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.soluong.IconPadding = 10;
            this.soluong.IconRight = null;
            this.soluong.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.soluong.Lines = new string[] {
        "0"};
            this.soluong.Location = new System.Drawing.Point(224, 146);
            this.soluong.MaxLength = 32767;
            this.soluong.MinimumSize = new System.Drawing.Size(1, 1);
            this.soluong.Modified = false;
            this.soluong.Multiline = false;
            this.soluong.Name = "soluong";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.soluong.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.soluong.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.soluong.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.soluong.OnIdleState = stateProperties4;
            this.soluong.Padding = new System.Windows.Forms.Padding(3);
            this.soluong.PasswordChar = '\0';
            this.soluong.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.soluong.PlaceholderText = "";
            this.soluong.ReadOnly = false;
            this.soluong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.soluong.SelectedText = "";
            this.soluong.SelectionLength = 0;
            this.soluong.SelectionStart = 0;
            this.soluong.ShortcutsEnabled = true;
            this.soluong.Size = new System.Drawing.Size(68, 41);
            this.soluong.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.soluong.TabIndex = 9;
            this.soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soluong.TextMarginBottom = 0;
            this.soluong.TextMarginLeft = 3;
            this.soluong.TextMarginTop = 0;
            this.soluong.TextPlaceholder = "";
            this.soluong.UseSystemPasswordChar = false;
            this.soluong.WordWrap = true;
            // 
            // thanhtien
            // 
            this.thanhtien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thanhtien.AutoSize = true;
            this.thanhtien.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.thanhtien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhtien.ForeColor = System.Drawing.Color.Red;
            this.thanhtien.Location = new System.Drawing.Point(488, 157);
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Size = new System.Drawing.Size(84, 28);
            this.thanhtien.TabIndex = 12;
            this.thanhtien.Text = "150000";
            this.thanhtien.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(363, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Thành tiền:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // maGioHang
            // 
            this.maGioHang.AutoSize = true;
            this.maGioHang.Location = new System.Drawing.Point(0, 0);
            this.maGioHang.Name = "maGioHang";
            this.maGioHang.Size = new System.Drawing.Size(0, 16);
            this.maGioHang.TabIndex = 14;
            this.maGioHang.Visible = false;
            // 
            // maSach
            // 
            this.maSach.AutoSize = true;
            this.maSach.Location = new System.Drawing.Point(0, 0);
            this.maSach.Name = "maSach";
            this.maSach.Size = new System.Drawing.Size(0, 16);
            this.maSach.TabIndex = 15;
            this.maSach.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orange;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.giam_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Orange;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(298, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.tang_Click);
            // 
            // ItemInCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderRadius = 10;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maSach);
            this.Controls.Add(this.maGioHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thanhtien);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.price);
            this.Controls.Add(this.priceDiscount);
            this.Controls.Add(this.title);
            this.Controls.Add(this.image);
            this.Name = "ItemInCart";
            this.Size = new System.Drawing.Size(639, 216);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox image;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label price;
        public System.Windows.Forms.Label priceDiscount;
        public Bunifu.UI.WinForms.BunifuTextBox soluong;
        public System.Windows.Forms.Label thanhtien;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label maGioHang;
        public System.Windows.Forms.Label maSach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
