namespace BookStore.View
{
    partial class OrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetail));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.image = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.priceDiscount = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.thanhtien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMuaLai = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bookId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.Cursor = System.Windows.Forms.Cursors.Default;
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(23, 15);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(117, 173);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(163, 24);
            this.title.MaximumSize = new System.Drawing.Size(800, 0);
            this.title.MinimumSize = new System.Drawing.Size(800, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(800, 35);
            this.title.TabIndex = 7;
            this.title.Text = "THẦN THOẠI HY LẠP";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceDiscount
            // 
            this.priceDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceDiscount.AutoSize = true;
            this.priceDiscount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.priceDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceDiscount.ForeColor = System.Drawing.Color.Black;
            this.priceDiscount.Location = new System.Drawing.Point(167, 70);
            this.priceDiscount.Name = "priceDiscount";
            this.priceDiscount.Size = new System.Drawing.Size(54, 28);
            this.priceDiscount.TabIndex = 8;
            this.priceDiscount.Text = "Giá: ";
            this.priceDiscount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // price
            // 
            this.price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.price.AutoSize = true;
            this.price.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Red;
            this.price.Location = new System.Drawing.Point(227, 70);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(103, 28);
            this.price.TabIndex = 10;
            this.price.Text = "150000 đ";
            this.price.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // quantity
            // 
            this.quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity.AutoSize = true;
            this.quantity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.Color.Black;
            this.quantity.Location = new System.Drawing.Point(282, 108);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(24, 28);
            this.quantity.TabIndex = 12;
            this.quantity.Text = "2";
            this.quantity.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(167, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số lượng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.thanhtien.Location = new System.Drawing.Point(299, 148);
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Size = new System.Drawing.Size(103, 28);
            this.thanhtien.TabIndex = 14;
            this.thanhtien.Text = "300000 đ";
            this.thanhtien.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(165, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thành tiền:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnMuaLai
            // 
            this.btnMuaLai.AllowAnimations = true;
            this.btnMuaLai.AllowMouseEffects = true;
            this.btnMuaLai.AllowToggling = false;
            this.btnMuaLai.AnimationSpeed = 200;
            this.btnMuaLai.AutoGenerateColors = false;
            this.btnMuaLai.AutoRoundBorders = false;
            this.btnMuaLai.AutoSizeLeftIcon = true;
            this.btnMuaLai.AutoSizeRightIcon = true;
            this.btnMuaLai.BackColor = System.Drawing.Color.Transparent;
            this.btnMuaLai.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnMuaLai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMuaLai.BackgroundImage")));
            this.btnMuaLai.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMuaLai.ButtonText = "Mua lại";
            this.btnMuaLai.ButtonTextMarginLeft = 0;
            this.btnMuaLai.ColorContrastOnClick = 45;
            this.btnMuaLai.ColorContrastOnHover = 45;
            this.btnMuaLai.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnMuaLai.CustomizableEdges = borderEdges1;
            this.btnMuaLai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMuaLai.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMuaLai.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMuaLai.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMuaLai.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMuaLai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaLai.ForeColor = System.Drawing.Color.White;
            this.btnMuaLai.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuaLai.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMuaLai.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnMuaLai.IconMarginLeft = 11;
            this.btnMuaLai.IconPadding = 10;
            this.btnMuaLai.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMuaLai.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMuaLai.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMuaLai.IconSize = 25;
            this.btnMuaLai.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMuaLai.IdleBorderRadius = 10;
            this.btnMuaLai.IdleBorderThickness = 1;
            this.btnMuaLai.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnMuaLai.IdleIconLeftImage = null;
            this.btnMuaLai.IdleIconRightImage = null;
            this.btnMuaLai.IndicateFocus = false;
            this.btnMuaLai.Location = new System.Drawing.Point(819, 128);
            this.btnMuaLai.Name = "btnMuaLai";
            this.btnMuaLai.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMuaLai.OnDisabledState.BorderRadius = 10;
            this.btnMuaLai.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMuaLai.OnDisabledState.BorderThickness = 1;
            this.btnMuaLai.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMuaLai.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMuaLai.OnDisabledState.IconLeftImage = null;
            this.btnMuaLai.OnDisabledState.IconRightImage = null;
            this.btnMuaLai.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnMuaLai.onHoverState.BorderRadius = 10;
            this.btnMuaLai.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMuaLai.onHoverState.BorderThickness = 1;
            this.btnMuaLai.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnMuaLai.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMuaLai.onHoverState.IconLeftImage = null;
            this.btnMuaLai.onHoverState.IconRightImage = null;
            this.btnMuaLai.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMuaLai.OnIdleState.BorderRadius = 10;
            this.btnMuaLai.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMuaLai.OnIdleState.BorderThickness = 1;
            this.btnMuaLai.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnMuaLai.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMuaLai.OnIdleState.IconLeftImage = null;
            this.btnMuaLai.OnIdleState.IconRightImage = null;
            this.btnMuaLai.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnMuaLai.OnPressedState.BorderRadius = 10;
            this.btnMuaLai.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMuaLai.OnPressedState.BorderThickness = 1;
            this.btnMuaLai.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnMuaLai.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMuaLai.OnPressedState.IconLeftImage = null;
            this.btnMuaLai.OnPressedState.IconRightImage = null;
            this.btnMuaLai.Size = new System.Drawing.Size(150, 48);
            this.btnMuaLai.TabIndex = 15;
            this.btnMuaLai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMuaLai.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMuaLai.TextMarginLeft = 0;
            this.btnMuaLai.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMuaLai.UseDefaultRadiusAndThickness = true;
            this.btnMuaLai.Click += new System.EventHandler(this.btnMuaLai_Click);
            // 
            // bookId
            // 
            this.bookId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookId.AutoSize = true;
            this.bookId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bookId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookId.ForeColor = System.Drawing.Color.Black;
            this.bookId.Location = new System.Drawing.Point(492, 90);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(0, 28);
            this.bookId.TabIndex = 16;
            this.bookId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bookId.Visible = false;
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderRadius = 10;
            this.Controls.Add(this.bookId);
            this.Controls.Add(this.btnMuaLai);
            this.Controls.Add(this.thanhtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.priceDiscount);
            this.Controls.Add(this.title);
            this.Controls.Add(this.image);
            this.Name = "OrderDetail";
            this.Size = new System.Drawing.Size(1008, 209);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox image;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label priceDiscount;
        public System.Windows.Forms.Label price;
        public System.Windows.Forms.Label quantity;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label thanhtien;
        public System.Windows.Forms.Label label5;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMuaLai;
        public System.Windows.Forms.Label bookId;
    }
}
