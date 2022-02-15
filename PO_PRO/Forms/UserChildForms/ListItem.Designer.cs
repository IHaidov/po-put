
namespace PO_PRO.Forms.UserChildForms
{
    partial class ListItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStars = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pbPhoto = new FontAwesome.Sharp.IconPictureBox();
            this.btnHotelName = new FontAwesome.Sharp.IconButton();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnSeeMore = new FontAwesome.Sharp.IconButton();
            this.lblGlobalInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStars);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.pbPhoto);
            this.panel1.Controls.Add(this.btnHotelName);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.btnSeeMore);
            this.panel1.Controls.Add(this.lblGlobalInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 220);
            this.panel1.TabIndex = 11;
            // 
            // lblStars
            // 
            this.lblStars.AutoSize = true;
            this.lblStars.BackColor = System.Drawing.Color.Transparent;
            this.lblStars.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStars.ForeColor = System.Drawing.Color.Black;
            this.lblStars.Location = new System.Drawing.Point(626, 23);
            this.lblStars.Name = "lblStars";
            this.lblStars.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStars.Size = new System.Drawing.Size(66, 30);
            this.lblStars.TabIndex = 11;
            this.lblStars.Text = "Stars";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(626, 78);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(72, 30);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbPhoto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pbPhoto.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbPhoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbPhoto.IconSize = 200;
            this.pbPhoto.Location = new System.Drawing.Point(10, 10);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(200, 200);
            this.pbPhoto.TabIndex = 0;
            this.pbPhoto.TabStop = false;
            // 
            // btnHotelName
            // 
            this.btnHotelName.AutoSize = true;
            this.btnHotelName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHotelName.BackColor = System.Drawing.Color.Transparent;
            this.btnHotelName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelName.FlatAppearance.BorderSize = 0;
            this.btnHotelName.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnHotelName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHotelName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHotelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotelName.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btnHotelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHotelName.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHotelName.IconColor = System.Drawing.Color.Black;
            this.btnHotelName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHotelName.IconSize = 24;
            this.btnHotelName.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnHotelName.Location = new System.Drawing.Point(216, 10);
            this.btnHotelName.Name = "btnHotelName";
            this.btnHotelName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHotelName.Size = new System.Drawing.Size(199, 47);
            this.btnHotelName.TabIndex = 9;
            this.btnHotelName.Text = "Hotel Name";
            this.btnHotelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotelName.UseVisualStyleBackColor = false;
            this.btnHotelName.Click += new System.EventHandler(this.btnHotelName_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(225, 64);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 22);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // btnSeeMore
            // 
            this.btnSeeMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeeMore.AutoSize = true;
            this.btnSeeMore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeeMore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSeeMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeMore.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSeeMore.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSeeMore.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSeeMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeMore.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnSeeMore.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnSeeMore.IconColor = System.Drawing.Color.Black;
            this.btnSeeMore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeeMore.IconSize = 24;
            this.btnSeeMore.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSeeMore.Location = new System.Drawing.Point(631, 158);
            this.btnSeeMore.Name = "btnSeeMore";
            this.btnSeeMore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSeeMore.Size = new System.Drawing.Size(144, 42);
            this.btnSeeMore.TabIndex = 8;
            this.btnSeeMore.Text = "Reserve";
            this.btnSeeMore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeMore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeeMore.UseVisualStyleBackColor = false;
            // 
            // lblGlobalInfo
            // 
            this.lblGlobalInfo.AutoSize = true;
            this.lblGlobalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblGlobalInfo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGlobalInfo.ForeColor = System.Drawing.Color.Black;
            this.lblGlobalInfo.Location = new System.Drawing.Point(224, 91);
            this.lblGlobalInfo.MaximumSize = new System.Drawing.Size(300, 300);
            this.lblGlobalInfo.Name = "lblGlobalInfo";
            this.lblGlobalInfo.Size = new System.Drawing.Size(146, 30);
            this.lblGlobalInfo.TabIndex = 0;
            this.lblGlobalInfo.Text = "Global Info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 1);
            this.panel2.TabIndex = 12;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(795, 227);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox pbPhoto;
        private FontAwesome.Sharp.IconButton btnHotelName;
        private System.Windows.Forms.Label lblCity;
        private FontAwesome.Sharp.IconButton btnSeeMore;
        private System.Windows.Forms.Label lblGlobalInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.Label lblPrice;
    }
}
