
namespace PO_PRO.Forms.UserChildForms
{
    partial class SearchFrom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnFacilities = new FontAwesome.Sharp.IconButton();
            this.btnAdultsMinus = new FontAwesome.Sharp.IconButton();
            this.btnChildrenPlus = new FontAwesome.Sharp.IconButton();
            this.btnAdultsPlus = new FontAwesome.Sharp.IconButton();
            this.btnCheckOut = new FontAwesome.Sharp.IconButton();
            this.btnCheckIn = new FontAwesome.Sharp.IconButton();
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChildrenMinus = new FontAwesome.Sharp.IconButton();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelFilter.Controls.Add(this.txtLocation);
            this.panelFilter.Controls.Add(this.btnFacilities);
            this.panelFilter.Controls.Add(this.btnChildrenMinus);
            this.panelFilter.Controls.Add(this.btnAdultsMinus);
            this.panelFilter.Controls.Add(this.btnChildrenPlus);
            this.panelFilter.Controls.Add(this.btnAdultsPlus);
            this.panelFilter.Controls.Add(this.btnCheckOut);
            this.panelFilter.Controls.Add(this.btnCheckIn);
            this.panelFilter.Controls.Add(this.lblAdults);
            this.panelFilter.Controls.Add(this.lblChildren);
            this.panelFilter.Controls.Add(this.label3);
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.lblCheckOut);
            this.panelFilter.Controls.Add(this.lblCheckIn);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(225, 620);
            this.panelFilter.TabIndex = 1;
            // 
            // btnFacilities
            // 
            this.btnFacilities.BackColor = System.Drawing.Color.Transparent;
            this.btnFacilities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacilities.FlatAppearance.BorderSize = 0;
            this.btnFacilities.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFacilities.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFacilities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilities.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnFacilities.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.btnFacilities.IconColor = System.Drawing.Color.Black;
            this.btnFacilities.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacilities.IconSize = 24;
            this.btnFacilities.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnFacilities.Location = new System.Drawing.Point(15, 401);
            this.btnFacilities.Name = "btnFacilities";
            this.btnFacilities.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFacilities.Size = new System.Drawing.Size(180, 40);
            this.btnFacilities.TabIndex = 8;
            this.btnFacilities.Text = "Facilities";
            this.btnFacilities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacilities.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFacilities.UseVisualStyleBackColor = false;
            this.btnFacilities.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnFacilities.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnAdultsMinus
            // 
            this.btnAdultsMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnAdultsMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdultsMinus.FlatAppearance.BorderSize = 0;
            this.btnAdultsMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAdultsMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdultsMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdultsMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdultsMinus.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnAdultsMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnAdultsMinus.IconColor = System.Drawing.Color.Black;
            this.btnAdultsMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdultsMinus.IconSize = 24;
            this.btnAdultsMinus.Location = new System.Drawing.Point(142, 294);
            this.btnAdultsMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdultsMinus.Name = "btnAdultsMinus";
            this.btnAdultsMinus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdultsMinus.Size = new System.Drawing.Size(24, 24);
            this.btnAdultsMinus.TabIndex = 4;
            this.btnAdultsMinus.UseVisualStyleBackColor = false;
            this.btnAdultsMinus.Click += new System.EventHandler(this.btnAdultsMinus_Click);
            this.btnAdultsMinus.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnAdultsMinus.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnChildrenPlus
            // 
            this.btnChildrenPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnChildrenPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChildrenPlus.FlatAppearance.BorderSize = 0;
            this.btnChildrenPlus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnChildrenPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChildrenPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChildrenPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildrenPlus.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnChildrenPlus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnChildrenPlus.IconColor = System.Drawing.Color.Black;
            this.btnChildrenPlus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChildrenPlus.IconSize = 24;
            this.btnChildrenPlus.Location = new System.Drawing.Point(196, 352);
            this.btnChildrenPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnChildrenPlus.Name = "btnChildrenPlus";
            this.btnChildrenPlus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChildrenPlus.Size = new System.Drawing.Size(24, 24);
            this.btnChildrenPlus.TabIndex = 7;
            this.btnChildrenPlus.UseVisualStyleBackColor = false;
            this.btnChildrenPlus.Click += new System.EventHandler(this.btnChildrenPlus_Click);
            this.btnChildrenPlus.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnChildrenPlus.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnAdultsPlus
            // 
            this.btnAdultsPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnAdultsPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdultsPlus.FlatAppearance.BorderSize = 0;
            this.btnAdultsPlus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAdultsPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdultsPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdultsPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdultsPlus.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnAdultsPlus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdultsPlus.IconColor = System.Drawing.Color.Black;
            this.btnAdultsPlus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdultsPlus.IconSize = 24;
            this.btnAdultsPlus.Location = new System.Drawing.Point(196, 294);
            this.btnAdultsPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdultsPlus.Name = "btnAdultsPlus";
            this.btnAdultsPlus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdultsPlus.Size = new System.Drawing.Size(24, 24);
            this.btnAdultsPlus.TabIndex = 5;
            this.btnAdultsPlus.UseVisualStyleBackColor = false;
            this.btnAdultsPlus.Click += new System.EventHandler(this.btnAdultsPlus_Click);
            this.btnAdultsPlus.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnAdultsPlus.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnCheckOut.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.btnCheckOut.IconColor = System.Drawing.Color.Black;
            this.btnCheckOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckOut.IconSize = 24;
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCheckOut.Location = new System.Drawing.Point(12, 194);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCheckOut.Size = new System.Drawing.Size(180, 40);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            this.btnCheckOut.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnCheckOut.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnCheckIn.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.btnCheckIn.IconColor = System.Drawing.Color.Black;
            this.btnCheckIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckIn.IconSize = 24;
            this.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCheckIn.Location = new System.Drawing.Point(15, 101);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCheckIn.Size = new System.Drawing.Size(180, 40);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            this.btnCheckIn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnCheckIn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.BackColor = System.Drawing.Color.Transparent;
            this.lblAdults.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdults.Location = new System.Drawing.Point(169, 288);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(26, 30);
            this.lblAdults.TabIndex = 0;
            this.lblAdults.Text = "1";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.BackColor = System.Drawing.Color.Transparent;
            this.lblChildren.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChildren.Location = new System.Drawing.Point(169, 346);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(26, 30);
            this.lblChildren.TabIndex = 0;
            this.lblChildren.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Children";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adults";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // btnChildrenMinus
            // 
            this.btnChildrenMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnChildrenMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChildrenMinus.FlatAppearance.BorderSize = 0;
            this.btnChildrenMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnChildrenMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChildrenMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChildrenMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildrenMinus.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnChildrenMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnChildrenMinus.IconColor = System.Drawing.Color.Black;
            this.btnChildrenMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChildrenMinus.IconSize = 24;
            this.btnChildrenMinus.Location = new System.Drawing.Point(142, 352);
            this.btnChildrenMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnChildrenMinus.Name = "btnChildrenMinus";
            this.btnChildrenMinus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChildrenMinus.Size = new System.Drawing.Size(24, 24);
            this.btnChildrenMinus.TabIndex = 6;
            this.btnChildrenMinus.UseVisualStyleBackColor = false;
            this.btnChildrenMinus.Click += new System.EventHandler(this.btnChildrenMinus_Click);
            this.btnChildrenMinus.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnChildrenMinus.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.SystemColors.Info;
            this.txtLocation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLocation.Location = new System.Drawing.Point(15, 60);
            this.txtLocation.MaxLength = 35000;
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(190, 34);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.Text = "Where to go?";
            // 
            // panelShadow
            // 
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelShadow.Location = new System.Drawing.Point(225, 0);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1, 620);
            this.panelShadow.TabIndex = 2;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Location = new System.Drawing.Point(250, 101);
            this.monthCalendar.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.monthCalendar.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckIn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCheckIn.ForeColor = System.Drawing.Color.Black;
            this.lblCheckIn.Location = new System.Drawing.Point(20, 147);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(117, 30);
            this.lblCheckIn.TabIndex = 0;
            this.lblCheckIn.Text = "Location";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckOut.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCheckOut.ForeColor = System.Drawing.Color.Black;
            this.lblCheckOut.Location = new System.Drawing.Point(20, 239);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(117, 30);
            this.lblCheckOut.TabIndex = 0;
            this.lblCheckOut.Text = "Location";
            // 
            // SearchFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 620);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelFilter);
            this.Name = "SearchFrom";
            this.Text = "SearchFrom";
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCheckOut;
        private FontAwesome.Sharp.IconButton btnCheckIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnFacilities;
        private FontAwesome.Sharp.IconButton btnAdultsPlus;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblChildren;
        private FontAwesome.Sharp.IconButton btnAdultsMinus;
        private FontAwesome.Sharp.IconButton btnChildrenPlus;
        private FontAwesome.Sharp.IconButton btnChildrenMinus;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
    }
}