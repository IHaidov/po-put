using System;
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
using Newtonsoft.Json;
using PO_PRO.Classes;

namespace PO_PRO.Forms
{
    public partial class UserForm : Form
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

        private Person user;
        private Form currentChildForm;

        public UserForm()
        {
            InitializeComponent();
            panelMenu.Paint += new PaintEventHandler(SetFilterBackground);
            panelShadow.Paint += new PaintEventHandler(SetShadowBackground);
        }
        public UserForm(string key)
        {
            InitializeComponent();
            panelMenu.Paint += new PaintEventHandler(SetFilterBackground);
            panelShadow.Paint += new PaintEventHandler(SetShadowBackground);
            string temp;
            DB.Read(key, out temp);
            user = JsonConvert.DeserializeObject<Person>(temp);
            btnProfile.Text = user.Username!=""?user.Username:user.Email;
            if(user.User_Type == Classes.Type.User)
            {
                btnAddProperty.Visible = false;
                btnHistory.Width = 240;
                btnSearch.Width = 240;
            }
        }
        private void SetFilterBackground(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, ColorTranslator.FromHtml("#c8641c"), ColorTranslator.FromHtml("#df9925"), 180f);       
            graphics.FillRectangle(b, gradient_rectangle);
        }
        private void SetShadowBackground(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, ColorTranslator.FromHtml("#b35b1d"), ColorTranslator.FromHtml("#ba8020"), 180f);       
            graphics.FillRectangle(b, gradient_rectangle);
        }
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open a single form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Visible = true;
        }

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
        #region Menu
        private void btnLogo_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)  currentChildForm.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserChildForms.SearchFrom());
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserChildForms.OrderHistory());
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserChildForms.Profile(user.Email));
        }
        #endregion
        #region WindowTools
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
        Point lastPoint;
        private void UserForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void UserForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
