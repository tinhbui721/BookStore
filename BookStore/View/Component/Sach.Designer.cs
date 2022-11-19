namespace BookStore.View
{
    partial class Sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sach));
            this.title = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.priceDiscount = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToCart)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.title.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 298);
            this.title.MaximumSize = new System.Drawing.Size(243, 0);
            this.title.MinimumSize = new System.Drawing.Size(243, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(243, 24);
            this.title.TabIndex = 4;
            this.title.Text = "Thần thoại Hy Lạp";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // image
            // 
            this.image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(34, 13);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(173, 278);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 3;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // priceDiscount
            // 
            this.priceDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.priceDiscount.AutoSize = true;
            this.priceDiscount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.priceDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceDiscount.ForeColor = System.Drawing.Color.Red;
            this.priceDiscount.Location = new System.Drawing.Point(0, 371);
            this.priceDiscount.Name = "priceDiscount";
            this.priceDiscount.Size = new System.Drawing.Size(84, 28);
            this.priceDiscount.TabIndex = 5;
            this.priceDiscount.Text = "150000";
            this.priceDiscount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // price
            // 
            this.price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.price.AutoSize = true;
            this.price.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.price.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.DarkGray;
            this.price.Location = new System.Drawing.Point(0, 343);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(84, 28);
            this.price.TabIndex = 6;
            this.price.Text = "150000";
            this.price.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // addToCart
            // 
            this.addToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCart.Image = ((System.Drawing.Image)(resources.GetObject("addToCart.Image")));
            this.addToCart.Location = new System.Drawing.Point(180, 342);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(60, 60);
            this.addToCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addToCart.TabIndex = 7;
            this.addToCart.TabStop = false;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(0, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 16);
            this.id.TabIndex = 8;
            this.id.Visible = false;
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderRadius = 10;
            this.Controls.Add(this.id);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.price);
            this.Controls.Add(this.priceDiscount);
            this.Controls.Add(this.title);
            this.Controls.Add(this.image);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Sach";
            this.Size = new System.Drawing.Size(243, 405);
            this.Click += new System.EventHandler(this.Sach_Click);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label priceDiscount;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.PictureBox addToCart;
        private System.Windows.Forms.Label id;
    }
}
