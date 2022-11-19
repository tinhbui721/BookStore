namespace BookStore.View
{
    partial class Comment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comment));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.userName = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.rate = new Bunifu.UI.WinForms.BunifuRating();
            this.btnXoaComment = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Cursor = System.Windows.Forms.Cursors.Default;
            this.userName.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(3, 4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(135, 24);
            this.userName.TabIndex = 5;
            this.userName.Text = "Bùi Văn Tình";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(37, 37);
            this.content.MaximumSize = new System.Drawing.Size(310, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(254, 23);
            this.content.TabIndex = 6;
            this.content.Text = "Sánh nay đọc hay khỏi phải bàn";
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.date.AutoSize = true;
            this.date.Cursor = System.Windows.Forms.Cursors.Default;
            this.date.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.date.Location = new System.Drawing.Point(261, 7);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(96, 23);
            this.date.TabIndex = 7;
            this.date.Text = "29/10/2022";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rate
            // 
            this.rate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rate.BackColor = System.Drawing.Color.Transparent;
            this.rate.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rate.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.rate.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rate.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rate.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rate.InnerRadius = 2F;
            this.rate.Location = new System.Drawing.Point(210, 91);
            this.rate.Name = "rate";
            this.rate.OuterRadius = 10F;
            this.rate.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rate.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rate.ReadOnly = true;
            this.rate.RightClickToClear = true;
            this.rate.Size = new System.Drawing.Size(121, 22);
            this.rate.TabIndex = 8;
            this.rate.Text = "bunifuRating1";
            this.rate.Value = 3;
            // 
            // btnXoaComment
            // 
            this.btnXoaComment.AllowAnimations = true;
            this.btnXoaComment.AllowMouseEffects = true;
            this.btnXoaComment.AllowToggling = false;
            this.btnXoaComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaComment.AnimationSpeed = 200;
            this.btnXoaComment.AutoGenerateColors = false;
            this.btnXoaComment.AutoRoundBorders = false;
            this.btnXoaComment.AutoSizeLeftIcon = true;
            this.btnXoaComment.AutoSizeRightIcon = true;
            this.btnXoaComment.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaComment.BackColor1 = System.Drawing.Color.Red;
            this.btnXoaComment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaComment.BackgroundImage")));
            this.btnXoaComment.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoaComment.ButtonText = "Xóa";
            this.btnXoaComment.ButtonTextMarginLeft = 0;
            this.btnXoaComment.ColorContrastOnClick = 45;
            this.btnXoaComment.ColorContrastOnHover = 45;
            this.btnXoaComment.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnXoaComment.CustomizableEdges = borderEdges1;
            this.btnXoaComment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaComment.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoaComment.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoaComment.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoaComment.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXoaComment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaComment.ForeColor = System.Drawing.Color.White;
            this.btnXoaComment.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaComment.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXoaComment.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXoaComment.IconMarginLeft = 11;
            this.btnXoaComment.IconPadding = 10;
            this.btnXoaComment.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaComment.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXoaComment.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXoaComment.IconSize = 25;
            this.btnXoaComment.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXoaComment.IdleBorderRadius = 10;
            this.btnXoaComment.IdleBorderThickness = 1;
            this.btnXoaComment.IdleFillColor = System.Drawing.Color.Red;
            this.btnXoaComment.IdleIconLeftImage = null;
            this.btnXoaComment.IdleIconRightImage = null;
            this.btnXoaComment.IndicateFocus = false;
            this.btnXoaComment.Location = new System.Drawing.Point(5, 86);
            this.btnXoaComment.Name = "btnXoaComment";
            this.btnXoaComment.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoaComment.OnDisabledState.BorderRadius = 10;
            this.btnXoaComment.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoaComment.OnDisabledState.BorderThickness = 1;
            this.btnXoaComment.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoaComment.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoaComment.OnDisabledState.IconLeftImage = null;
            this.btnXoaComment.OnDisabledState.IconRightImage = null;
            this.btnXoaComment.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXoaComment.onHoverState.BorderRadius = 10;
            this.btnXoaComment.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoaComment.onHoverState.BorderThickness = 1;
            this.btnXoaComment.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXoaComment.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoaComment.onHoverState.IconLeftImage = null;
            this.btnXoaComment.onHoverState.IconRightImage = null;
            this.btnXoaComment.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXoaComment.OnIdleState.BorderRadius = 10;
            this.btnXoaComment.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoaComment.OnIdleState.BorderThickness = 1;
            this.btnXoaComment.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.btnXoaComment.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXoaComment.OnIdleState.IconLeftImage = null;
            this.btnXoaComment.OnIdleState.IconRightImage = null;
            this.btnXoaComment.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.btnXoaComment.OnPressedState.BorderRadius = 10;
            this.btnXoaComment.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoaComment.OnPressedState.BorderThickness = 1;
            this.btnXoaComment.OnPressedState.FillColor = System.Drawing.Color.Red;
            this.btnXoaComment.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXoaComment.OnPressedState.IconLeftImage = null;
            this.btnXoaComment.OnPressedState.IconRightImage = null;
            this.btnXoaComment.Size = new System.Drawing.Size(55, 35);
            this.btnXoaComment.TabIndex = 9;
            this.btnXoaComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoaComment.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoaComment.TextMarginLeft = 0;
            this.btnXoaComment.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXoaComment.UseDefaultRadiusAndThickness = true;
            this.btnXoaComment.Click += new System.EventHandler(this.btnXoaComment_Click);
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoaComment);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.content);
            this.Controls.Add(this.userName);
            this.Name = "Comment";
            this.Size = new System.Drawing.Size(373, 124);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label content;
        private System.Windows.Forms.Label date;
        private Bunifu.UI.WinForms.BunifuRating rate;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXoaComment;
    }
}
