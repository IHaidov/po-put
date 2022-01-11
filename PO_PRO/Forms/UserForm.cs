using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO_PRO.Forms
{
    public partial class UserForm : Form
    {
        private Form currentChildForm;
        public UserForm()
        {
            InitializeComponent();
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

        private void Reset()
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserChildForms.SearchFrom());
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
