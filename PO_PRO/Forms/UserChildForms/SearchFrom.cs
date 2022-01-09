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

namespace PO_PRO.Forms.UserChildForms
{
    public partial class SearchFrom : Form
    {
        public SearchFrom()
        {
            InitializeComponent();
            panelFilter.Paint += new PaintEventHandler(SetFilterBackground);
            panelShadow.Paint += new PaintEventHandler(SetShadowBackground);
            lblCheckIn.Text = DateTime.Today.ToString("dd.MM.yyyy");
            lblCheckOut.Text = DateTime.Today.ToString("dd.MM.yyyy");
        }
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

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, ColorTranslator.FromHtml("#b55a19"), ColorTranslator.FromHtml("#d59223"), 75f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
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

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = true;
            ChangeDate(lblCheckIn);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            string date = monthCalendar.SelectionRange.Start.ToShortDateString();
            MessageBox.Show(date);
            
        }

        private void ChangeDate(Label label)
        {
            string date = monthCalendar.SelectionRange.Start.ToShortDateString();
            label.Text = date;
        }
    }
}
