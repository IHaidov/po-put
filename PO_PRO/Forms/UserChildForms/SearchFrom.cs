﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace PO_PRO.Forms.UserChildForms
{
    public partial class SearchFrom : Form
    {
        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, AnimateWindowFlags flags);
        enum AnimateWindowFlags : uint
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }

        public SearchFrom()
        {
            InitializeComponent();
            panelFilter.Paint += new PaintEventHandler(SetFilterBackground);
            panelShadow.Paint += new PaintEventHandler(SetShadowBackground);
            lblCheckIn.Text = DateTime.Today.ToString("dd.MM.yyyy") + " -\n" + DateTime.Today.ToString("dd.MM.yyyy");
            btnFilter.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#b55a19");
            btnFilter.BackColor = ColorTranslator.FromHtml("#d59223");
            panelFacilities.Visible = false;
            btnHamburger.Visible = false;
            btnHamburger.Location = new Point(10, 10);
            monthCalendar.BringToFront();
        }
        #region BackgroundGradient
        private void SetFilterBackground(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, ColorTranslator.FromHtml("#c8641c"), ColorTranslator.FromHtml("#df9925"), 75f);
            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void SetShadowBackground(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, ColorTranslator.FromHtml("#b55a19"), ColorTranslator.FromHtml("#d59223"), 75f);       
            graphics.FillRectangle(b, gradient_rectangle);
        }
        #endregion
        private void BtnMouseEnter(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.ForeColor = Color.White;
            btn.IconColor = Color.White;
        }

        private void BtnMouseLeave(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.ForeColor = Color.Black;
            btn.IconColor = Color.Black;
        }

        #region PlusMinusButtons
        private void btnAdultsPlus_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(lblAdults.Text);
            number++;
            lblAdults.Text = number.ToString();
        }

        private void btnAdultsMinus_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(lblAdults.Text);
            if(number > 1)
            {
                number--;
                lblAdults.Text = number.ToString();
            }
        }

        private void btnChildrenPlus_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(lblChildren.Text);
            number++;
            lblChildren.Text = number.ToString();
        }

        private void btnChildrenMinus_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(lblChildren.Text);
            if(number > 0)
            {
                number--;
                lblChildren.Text = number.ToString();
            }
        }
        #endregion
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = !monthCalendar.Visible;
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblCheckIn.Text = monthCalendar.SelectionRange.Start.ToShortDateString() + " -\n" + monthCalendar.SelectionRange.End.ToShortDateString();
        }
        #region HamburgerMenu
        private void btnCloseMenu_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = false;
            panelShadow.Visible = false;
            AnimateWindow(panelFilter.Handle, 500, AnimateWindowFlags.AW_SLIDE | AnimateWindowFlags.AW_HOR_NEGATIVE | AnimateWindowFlags.AW_HIDE);
            btnHamburger.Visible = true;
            panelHotels.Left -= 3 * panelFilter.Size.Width / 4;
            panelHotels.Width += panelFilter.Size.Width / 2;
        }
        private void btnHamburger_Click(object sender, EventArgs e)
        {
            btnHamburger.Visible = false;
            panelHotels.Left += 3 * panelFilter.Size.Width / 4;
            panelHotels.Width -= panelFilter.Size.Width / 2;
            AnimateWindow(panelFilter.Handle, 500, AnimateWindowFlags.AW_SLIDE | AnimateWindowFlags.AW_HOR_POSITIVE);
            panelShadow.Visible = true;
        }
        #endregion
        private void btnFacilities_Click(object sender, EventArgs e)
        {
            panelFacilities.Visible = !panelFacilities.Visible;
        }
        //(Un)Check facilities
        private void CheckedClicked(IconButton btn)
        {
            if(btn.IconChar.ToString() == "CheckSquare")
            {
                btn.IconChar = IconChar.Square;
            }
            else if(btn.IconChar.ToString() == "Square")
            {
                btn.IconChar = IconChar.CheckSquare;
            }
        }
        
        #region Facilities
        private void btnPrivateBathroom_Click(object sender, EventArgs e)
        {
            CheckedClicked((IconButton)sender);
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            CheckedClicked((IconButton)sender);
        }

        private void btnBalcony_Click(object sender, EventArgs e)
        {
            CheckedClicked((IconButton)sender);
        }

        private void btnWifi_Click(object sender, EventArgs e)
        {
            CheckedClicked((IconButton)sender);
        }

        private void btnParking_Click(object sender, EventArgs e)
        {
            CheckedClicked((IconButton)sender);
        }

        private void btnPetsAllowed_Click(object sender, EventArgs e)
        {
            CheckedClicked((IconButton)sender);
        }

        private void btnFitnessCentre_Click(object sender, EventArgs e)
        {
            CheckedClicked((IconButton)sender);
        }

        private void btnElectricKettle_Click(object sender, EventArgs e)
        {
            CheckedClicked((IconButton)sender);
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            CheckedClicked((IconButton)sender);
        }
        #endregion
        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void ToggleSeeMore(Panel panel)
        {
            if(panel.Height == 220)
            {
                panel.AutoSize = true;
            }
            else
            {
                panel.AutoSize = false;
                panel.Height = 220;
            }
        }

        private void btnHotelName_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            Panel panel = (Panel)btn.Parent;
            ToggleSeeMore(panel);
        }

    }
}
