using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace PO_PRO.Forms.UserChildForms
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _hotelName;
        private string _city;
        private string _id;
        private double _price;
        private int _stars;
        private Image _photo;

        [Category("Custom Props")]
        public string HotelName
        {
            get { return _hotelName;  }
            set { _hotelName = value; btnHotelName.Text = value; }
        }
        [Category("Custom Props")]
        public string City
        {
            get { return _city;  }
            set { _city = value; lblCity.Text = value; }
        }
        [Category("Custom Props")]
        public Image Photo
        {
            get { return _photo; }
            set { _photo = value; pbPhoto.BackgroundImage = value; }
        }

        [Category("Custom Props")]
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public double Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value.ToString() + " zł"; }
        }

        [Category("Custom Props")]
        public int Stars
        {
            get { return _stars; }
            set { _stars = value; lblStars.Text = "Stars: " + value.ToString(); }
        }
        #endregion

        private void ToggleSeeMore(Panel panel)
        {
            if (panel.Height == 220)
            {
                panel.AutoSize = true;
                Height = panel.Height + 1;
            }
            else
            {
                panel.AutoSize = false;
                panel.Height = 220;
                Height = 221;
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
