
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
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.panelFacilities = new System.Windows.Forms.Panel();
            this.btnElectricKettle = new FontAwesome.Sharp.IconButton();
            this.btnFitnessCentre = new FontAwesome.Sharp.IconButton();
            this.btnParking = new FontAwesome.Sharp.IconButton();
            this.btnTV = new FontAwesome.Sharp.IconButton();
            this.btnPetsAllowed = new FontAwesome.Sharp.IconButton();
            this.btnWifi = new FontAwesome.Sharp.IconButton();
            this.btnBalcony = new FontAwesome.Sharp.IconButton();
            this.btnPrivateBathroom = new FontAwesome.Sharp.IconButton();
            this.btnKitchen = new FontAwesome.Sharp.IconButton();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.btnFacilities = new FontAwesome.Sharp.IconButton();
            this.btnCloseMenu = new FontAwesome.Sharp.IconButton();
            this.btnCheckIn = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnHamburger = new FontAwesome.Sharp.IconButton();
            this.flowLayoutHotels = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.panelFacilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelFilter.Controls.Add(this.numMax);
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.numMin);
            this.panelFilter.Controls.Add(this.panelFacilities);
            this.panelFilter.Controls.Add(this.txtLocation);
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.btnFacilities);
            this.panelFilter.Controls.Add(this.btnCloseMenu);
            this.panelFilter.Controls.Add(this.btnCheckIn);
            this.panelFilter.Controls.Add(this.label3);
            this.panelFilter.Controls.Add(this.lblCheckIn);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(225, 749);
            this.panelFilter.TabIndex = 1;
            // 
            // numMax
            // 
            this.numMax.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.numMax.Location = new System.Drawing.Point(125, 300);
            this.numMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(94, 36);
            this.numMax.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(103, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "-";
            // 
            // numMin
            // 
            this.numMin.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.numMin.Location = new System.Drawing.Point(8, 298);
            this.numMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(94, 36);
            this.numMin.TabIndex = 9;
            // 
            // panelFacilities
            // 
            this.panelFacilities.AutoScroll = true;
            this.panelFacilities.BackColor = System.Drawing.Color.Transparent;
            this.panelFacilities.Controls.Add(this.btnElectricKettle);
            this.panelFacilities.Controls.Add(this.btnFitnessCentre);
            this.panelFacilities.Controls.Add(this.btnParking);
            this.panelFacilities.Controls.Add(this.btnTV);
            this.panelFacilities.Controls.Add(this.btnPetsAllowed);
            this.panelFacilities.Controls.Add(this.btnWifi);
            this.panelFacilities.Controls.Add(this.btnBalcony);
            this.panelFacilities.Controls.Add(this.btnPrivateBathroom);
            this.panelFacilities.Controls.Add(this.btnKitchen);
            this.panelFacilities.Location = new System.Drawing.Point(0, 383);
            this.panelFacilities.Name = "panelFacilities";
            this.panelFacilities.Size = new System.Drawing.Size(225, 312);
            this.panelFacilities.TabIndex = 7;
            // 
            // btnElectricKettle
            // 
            this.btnElectricKettle.BackColor = System.Drawing.Color.Transparent;
            this.btnElectricKettle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElectricKettle.FlatAppearance.BorderSize = 0;
            this.btnElectricKettle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnElectricKettle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnElectricKettle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnElectricKettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElectricKettle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElectricKettle.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnElectricKettle.IconColor = System.Drawing.Color.Black;
            this.btnElectricKettle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnElectricKettle.IconSize = 20;
            this.btnElectricKettle.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnElectricKettle.Location = new System.Drawing.Point(8, 276);
            this.btnElectricKettle.Name = "btnElectricKettle";
            this.btnElectricKettle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnElectricKettle.Size = new System.Drawing.Size(190, 33);
            this.btnElectricKettle.TabIndex = 7;
            this.btnElectricKettle.Text = "Electric kettle";
            this.btnElectricKettle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElectricKettle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnElectricKettle.UseVisualStyleBackColor = false;
            this.btnElectricKettle.Click += new System.EventHandler(this.btnElectricKettle_Click);
            this.btnElectricKettle.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnElectricKettle.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnFitnessCentre
            // 
            this.btnFitnessCentre.BackColor = System.Drawing.Color.Transparent;
            this.btnFitnessCentre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFitnessCentre.FlatAppearance.BorderSize = 0;
            this.btnFitnessCentre.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFitnessCentre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFitnessCentre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFitnessCentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFitnessCentre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFitnessCentre.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnFitnessCentre.IconColor = System.Drawing.Color.Black;
            this.btnFitnessCentre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFitnessCentre.IconSize = 20;
            this.btnFitnessCentre.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnFitnessCentre.Location = new System.Drawing.Point(8, 237);
            this.btnFitnessCentre.Name = "btnFitnessCentre";
            this.btnFitnessCentre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFitnessCentre.Size = new System.Drawing.Size(190, 33);
            this.btnFitnessCentre.TabIndex = 6;
            this.btnFitnessCentre.Text = "Fitness centre";
            this.btnFitnessCentre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFitnessCentre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFitnessCentre.UseVisualStyleBackColor = false;
            this.btnFitnessCentre.Click += new System.EventHandler(this.btnFitnessCentre_Click);
            this.btnFitnessCentre.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnFitnessCentre.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnParking
            // 
            this.btnParking.BackColor = System.Drawing.Color.Transparent;
            this.btnParking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParking.FlatAppearance.BorderSize = 0;
            this.btnParking.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnParking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnParking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParking.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnParking.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnParking.IconColor = System.Drawing.Color.Black;
            this.btnParking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParking.IconSize = 20;
            this.btnParking.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnParking.Location = new System.Drawing.Point(8, 159);
            this.btnParking.Name = "btnParking";
            this.btnParking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnParking.Size = new System.Drawing.Size(190, 33);
            this.btnParking.TabIndex = 4;
            this.btnParking.Text = "Parking";
            this.btnParking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParking.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnParking.UseVisualStyleBackColor = false;
            this.btnParking.Click += new System.EventHandler(this.btnParking_Click);
            this.btnParking.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnParking.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnTV
            // 
            this.btnTV.BackColor = System.Drawing.Color.Transparent;
            this.btnTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTV.FlatAppearance.BorderSize = 0;
            this.btnTV.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnTV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTV.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTV.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnTV.IconColor = System.Drawing.Color.Black;
            this.btnTV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTV.IconSize = 20;
            this.btnTV.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTV.Location = new System.Drawing.Point(8, 315);
            this.btnTV.Name = "btnTV";
            this.btnTV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTV.Size = new System.Drawing.Size(190, 33);
            this.btnTV.TabIndex = 8;
            this.btnTV.Text = "TV";
            this.btnTV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTV.UseVisualStyleBackColor = false;
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            this.btnTV.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnTV.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnPetsAllowed
            // 
            this.btnPetsAllowed.BackColor = System.Drawing.Color.Transparent;
            this.btnPetsAllowed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPetsAllowed.FlatAppearance.BorderSize = 0;
            this.btnPetsAllowed.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPetsAllowed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPetsAllowed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPetsAllowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPetsAllowed.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPetsAllowed.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnPetsAllowed.IconColor = System.Drawing.Color.Black;
            this.btnPetsAllowed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPetsAllowed.IconSize = 20;
            this.btnPetsAllowed.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPetsAllowed.Location = new System.Drawing.Point(8, 198);
            this.btnPetsAllowed.Name = "btnPetsAllowed";
            this.btnPetsAllowed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPetsAllowed.Size = new System.Drawing.Size(190, 33);
            this.btnPetsAllowed.TabIndex = 5;
            this.btnPetsAllowed.Text = "Pets allowed";
            this.btnPetsAllowed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPetsAllowed.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPetsAllowed.UseVisualStyleBackColor = false;
            this.btnPetsAllowed.Click += new System.EventHandler(this.btnPetsAllowed_Click);
            this.btnPetsAllowed.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnPetsAllowed.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnWifi
            // 
            this.btnWifi.BackColor = System.Drawing.Color.Transparent;
            this.btnWifi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWifi.FlatAppearance.BorderSize = 0;
            this.btnWifi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnWifi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWifi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWifi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWifi.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnWifi.IconColor = System.Drawing.Color.Black;
            this.btnWifi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWifi.IconSize = 20;
            this.btnWifi.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnWifi.Location = new System.Drawing.Point(8, 120);
            this.btnWifi.Name = "btnWifi";
            this.btnWifi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnWifi.Size = new System.Drawing.Size(190, 33);
            this.btnWifi.TabIndex = 3;
            this.btnWifi.Text = "Free WiFi";
            this.btnWifi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWifi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWifi.UseVisualStyleBackColor = false;
            this.btnWifi.Click += new System.EventHandler(this.btnWifi_Click);
            this.btnWifi.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnWifi.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnBalcony
            // 
            this.btnBalcony.BackColor = System.Drawing.Color.Transparent;
            this.btnBalcony.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalcony.FlatAppearance.BorderSize = 0;
            this.btnBalcony.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBalcony.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBalcony.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBalcony.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalcony.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBalcony.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnBalcony.IconColor = System.Drawing.Color.Black;
            this.btnBalcony.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBalcony.IconSize = 20;
            this.btnBalcony.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBalcony.Location = new System.Drawing.Point(8, 81);
            this.btnBalcony.Name = "btnBalcony";
            this.btnBalcony.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBalcony.Size = new System.Drawing.Size(190, 33);
            this.btnBalcony.TabIndex = 2;
            this.btnBalcony.Text = "Balcony/Terrace";
            this.btnBalcony.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalcony.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBalcony.UseVisualStyleBackColor = false;
            this.btnBalcony.Click += new System.EventHandler(this.btnBalcony_Click);
            this.btnBalcony.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnBalcony.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnPrivateBathroom
            // 
            this.btnPrivateBathroom.BackColor = System.Drawing.Color.Transparent;
            this.btnPrivateBathroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrivateBathroom.FlatAppearance.BorderSize = 0;
            this.btnPrivateBathroom.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPrivateBathroom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrivateBathroom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrivateBathroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivateBathroom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrivateBathroom.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnPrivateBathroom.IconColor = System.Drawing.Color.Black;
            this.btnPrivateBathroom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrivateBathroom.IconSize = 20;
            this.btnPrivateBathroom.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPrivateBathroom.Location = new System.Drawing.Point(8, 3);
            this.btnPrivateBathroom.Name = "btnPrivateBathroom";
            this.btnPrivateBathroom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrivateBathroom.Size = new System.Drawing.Size(190, 33);
            this.btnPrivateBathroom.TabIndex = 0;
            this.btnPrivateBathroom.Text = "Private bathroom";
            this.btnPrivateBathroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrivateBathroom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrivateBathroom.UseVisualStyleBackColor = false;
            this.btnPrivateBathroom.Click += new System.EventHandler(this.btnPrivateBathroom_Click);
            this.btnPrivateBathroom.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnPrivateBathroom.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnKitchen
            // 
            this.btnKitchen.BackColor = System.Drawing.Color.Transparent;
            this.btnKitchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitchen.FlatAppearance.BorderSize = 0;
            this.btnKitchen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnKitchen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKitchen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitchen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKitchen.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnKitchen.IconColor = System.Drawing.Color.Black;
            this.btnKitchen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKitchen.IconSize = 20;
            this.btnKitchen.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnKitchen.Location = new System.Drawing.Point(8, 42);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKitchen.Size = new System.Drawing.Size(190, 33);
            this.btnKitchen.TabIndex = 1;
            this.btnKitchen.Text = "Kitchen";
            this.btnKitchen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitchen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKitchen.UseVisualStyleBackColor = false;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            this.btnKitchen.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnKitchen.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
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
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFilter.IconColor = System.Drawing.Color.Black;
            this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilter.IconSize = 30;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilter.Location = new System.Drawing.Point(0, 698);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFilter.Size = new System.Drawing.Size(225, 51);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            this.btnFilter.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnFilter.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
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
            this.btnFacilities.Location = new System.Drawing.Point(15, 337);
            this.btnFacilities.Name = "btnFacilities";
            this.btnFacilities.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFacilities.Size = new System.Drawing.Size(180, 40);
            this.btnFacilities.TabIndex = 8;
            this.btnFacilities.Text = "Facilities";
            this.btnFacilities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacilities.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFacilities.UseVisualStyleBackColor = false;
            this.btnFacilities.Click += new System.EventHandler(this.btnFacilities_Click);
            this.btnFacilities.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnFacilities.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnCloseMenu
            // 
            this.btnCloseMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseMenu.FlatAppearance.BorderSize = 0;
            this.btnCloseMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCloseMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCloseMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCloseMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMenu.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnCloseMenu.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCloseMenu.IconColor = System.Drawing.Color.Black;
            this.btnCloseMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseMenu.IconSize = 30;
            this.btnCloseMenu.Location = new System.Drawing.Point(190, 10);
            this.btnCloseMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseMenu.Name = "btnCloseMenu";
            this.btnCloseMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCloseMenu.Size = new System.Drawing.Size(30, 30);
            this.btnCloseMenu.TabIndex = 5;
            this.btnCloseMenu.UseVisualStyleBackColor = false;
            this.btnCloseMenu.Click += new System.EventHandler(this.btnCloseMenu_Click);
            this.btnCloseMenu.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnCloseMenu.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
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
            this.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckIn.Location = new System.Drawing.Point(15, 99);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCheckIn.Size = new System.Drawing.Size(183, 76);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check-in - Check-out";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            this.btnCheckIn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnCheckIn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price per night";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckIn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCheckIn.ForeColor = System.Drawing.Color.Black;
            this.lblCheckIn.Location = new System.Drawing.Point(28, 178);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(170, 74);
            this.lblCheckIn.TabIndex = 0;
            this.lblCheckIn.Text = "Location";
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
            // panelShadow
            // 
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelShadow.Location = new System.Drawing.Point(225, 0);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1, 749);
            this.panelShadow.TabIndex = 2;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Location = new System.Drawing.Point(234, 75);
            this.monthCalendar.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.monthCalendar.MaxSelectionCount = 365;
            this.monthCalendar.MinDate = new System.DateTime(2022, 2, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2022, 2, 1, 0, 0, 0, 0), new System.DateTime(2023, 1, 9, 0, 0, 0, 0));
            this.monthCalendar.TabIndex = 3;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // btnHamburger
            // 
            this.btnHamburger.BackColor = System.Drawing.Color.Transparent;
            this.btnHamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHamburger.FlatAppearance.BorderSize = 0;
            this.btnHamburger.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnHamburger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHamburger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHamburger.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnHamburger.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnHamburger.IconColor = System.Drawing.Color.Black;
            this.btnHamburger.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHamburger.IconSize = 30;
            this.btnHamburger.Location = new System.Drawing.Point(229, 10);
            this.btnHamburger.Margin = new System.Windows.Forms.Padding(0);
            this.btnHamburger.Name = "btnHamburger";
            this.btnHamburger.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHamburger.Size = new System.Drawing.Size(30, 30);
            this.btnHamburger.TabIndex = 5;
            this.btnHamburger.UseVisualStyleBackColor = false;
            this.btnHamburger.Click += new System.EventHandler(this.btnHamburger_Click);
            this.btnHamburger.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnHamburger.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // flowLayoutHotels
            // 
            this.flowLayoutHotels.AutoScroll = true;
            this.flowLayoutHotels.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutHotels.Location = new System.Drawing.Point(265, 50);
            this.flowLayoutHotels.Name = "flowLayoutHotels";
            this.flowLayoutHotels.Size = new System.Drawing.Size(795, 621);
            this.flowLayoutHotels.TabIndex = 7;
            // 
            // SearchFrom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 749);
            this.Controls.Add(this.flowLayoutHotels);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.btnHamburger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "SearchFrom";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchFrom";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.panelFacilities.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCheckIn;
        private FontAwesome.Sharp.IconButton btnFacilities;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lblCheckIn;
        private FontAwesome.Sharp.IconButton btnFilter;
        private FontAwesome.Sharp.IconButton btnHamburger;
        private FontAwesome.Sharp.IconButton btnCloseMenu;
        private FontAwesome.Sharp.IconButton btnPrivateBathroom;
        private System.Windows.Forms.Panel panelFacilities;
        private FontAwesome.Sharp.IconButton btnKitchen;
        private FontAwesome.Sharp.IconButton btnBalcony;
        private FontAwesome.Sharp.IconButton btnWifi;
        private FontAwesome.Sharp.IconButton btnParking;
        private FontAwesome.Sharp.IconButton btnElectricKettle;
        private FontAwesome.Sharp.IconButton btnFitnessCentre;
        private FontAwesome.Sharp.IconButton btnTV;
        private FontAwesome.Sharp.IconButton btnPetsAllowed;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutHotels;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Label label3;
    }
}