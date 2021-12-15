using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using PO_PRO.Forms;

namespace PO_PRO
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            ResetColor();
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, ColorTranslator.FromHtml("#2D3436"), ColorTranslator.FromHtml("#000000"), 75f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void onClick_Register(object sender, EventArgs e)
        {
            Register();
        }
        private void onClick_ClearFields(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            ClearFields();
            ResetColor();
        }

        private void onClick_Text(object sender, EventArgs e)
        {
            ResetColor();
        }

        private void onClick_BackToLogin(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void KeyDown_Form(object sender, KeyEventArgs e)
        {
            //ESC - exit an application
            if (e.KeyData == Keys.Escape)
            {
                ExitApplication();
            }
        }
        private void KeyDown_Text(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Register();
            }
            if (e.KeyData == Keys.Escape)
            {
                ExitApplication();
            }
        }

        private void Register()
        {
            //if txtUsername doesn't exit:
            if(txtPassword.Text == txtConfirm.Text)
            {
                MessageBox.Show("Successfully registered");
            }
            else
            {
                txtConfirm.BackColor = ColorTranslator.FromHtml("#ff8787");
                txtPassword.BackColor = ColorTranslator.FromHtml("#ff8787");
                MessageBox.Show("Passwords do not match");
            }
            //else write: "user with such nick exists, try to log in"
            ClearFields();
        }

        private void ExitApplication()
        {
            Application.Exit();
        }

        private void ClearFields()
        {
            //txtUsername.Text = ""; - don't want to erase login when passwords are incorrect
            txtPassword.Text = "";
            txtConfirm.Text = "";
        }

        private void ResetColor()
        {
            txtUsername.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
            txtConfirm.BackColor = Color.White;
        }

    }
}
