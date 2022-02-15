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
using PO_PRO.Classes;
using Newtonsoft.Json;

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
        //public List<Room> room = new List<Room>();
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
            dbUpdate();

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
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = !monthCalendar.Visible;
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if(monthCalendar.SelectionRange.Start >= DateTime.Today && monthCalendar.SelectionRange.End >= DateTime.Today)
            {
                lblCheckIn.Text = monthCalendar.SelectionRange.Start.ToShortDateString() + " -\n" + monthCalendar.SelectionRange.End.ToShortDateString();
            }
            else
            {
                lblCheckIn.Text = "Wrong range";
            }
        }
        #region HamburgerMenu
        private void btnCloseMenu_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = false;
            panelShadow.Visible = false;
            AnimateWindow(panelFilter.Handle, 500, AnimateWindowFlags.AW_SLIDE | AnimateWindowFlags.AW_HOR_NEGATIVE | AnimateWindowFlags.AW_HIDE);
            btnHamburger.Visible = true;
            flowLayoutHotels.Left -= 3 * panelFilter.Size.Width / 4;
            flowLayoutHotels.Width += panelFilter.Size.Width / 2;
        }
        private void btnHamburger_Click(object sender, EventArgs e)
        {
            btnHamburger.Visible = false;
            flowLayoutHotels.Left += 3 * panelFilter.Size.Width / 4;
            flowLayoutHotels.Width -= panelFilter.Size.Width / 2;
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

        #region HotelFilter
        private Dictionary<string, string> db_string = new Dictionary<string, string>();
        public List<Hotel> hotels = new List<Hotel>();
        public void dbUpdate()
        {
            try
            {
                db_string.Clear();
                DB.ReadAll(out db_string);

                foreach (var db_elem in db_string)
                {
                    if (db_elem.Key.Contains("HOT_"))
                        hotels.Add(JsonConvert.DeserializeObject<Hotel>(db_elem.Value));
                }

                //MessageBox.Show("DB is updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine("!!!!!" + ex);
                throw;
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(lblCheckIn.Text == "Wrong range" || numMax.Value < numMin.Value)
            {
                MessageBox.Show("Wrong date range\nPlease, correct it");
            }
            else
            {
                //MessageBox.Show(hotels.Count.ToString());
                flowLayoutHotels.Controls.Clear();
                PopulateItems();
                //MessageBox.Show(numMin.Value.ToString());
            }
        }

        private void PopulateItems()
        {
            List<Hotel> filteredHotels = new List<Hotel>();
            filteredHotels = hotels.ToList();
            IEnumerable<IconButton> facilities = panelFacilities.Controls.OfType<IconButton>();
            int k = 0;
            foreach (IconButton facility in facilities)
            {
                if (facility.IconChar.ToString() == "CheckSquare")
                {
                    //MessageBox.Show(facility.Text + " " + k.ToString());
                    foreach(Hotel hotel in hotels)
                    {
                        bool zm = false;
                        for(int j = 0; j < hotel.Facilities.Count; j++)
                        {
                            if((int)hotel.Facilities[j].Type == k)
                            {
                                zm = true;
                            }
                        }
                        if(!zm)
                        {
                            //MessageBox.Show(hotel.Name);
                            filteredHotels.Remove(hotel);
                            //usuń z wypisywanych
                        }
                    }
                }
                k++;
            }
            ListItem[] listItems = new ListItem[filteredHotels.Count];
            for (int i = 0; i < listItems.Length; i++)
            {
                bool zm = false;
                for(int j = 0; j < filteredHotels[i].Rooms.Count; j++)
                {
                    if(filteredHotels[i].Rooms[j].Price <= (double)numMax.Value && filteredHotels[i].Rooms[j].Price >= (double)numMin.Value)
                    {
                        if(filteredHotels[i].Address.City == txtLocation.Text)
                        {
                            zm = true;
                            listItems[i] = new ListItem();
                            listItems[i].City = filteredHotels[i].Address.City;
                            listItems[i].Price = filteredHotels[i].Rooms[j].Price;
                        }
                        break;
                    }
                }
                if(zm)
                {
                    listItems[i].HotelName = filteredHotels[i].Name;
                    listItems[i].Stars = filteredHotels[i].Stars;
                    listItems[i].GlobalInfo = filteredHotels[i].Info;
                }

                //add to flow layout
                if (flowLayoutHotels.Controls.Count < 0)
                {
                    flowLayoutHotels.Controls.Clear();
                }
                flowLayoutHotels.Controls.Add(listItems[i]);
                //flowLayoutHotels.Controls.IndexOf
            }
            if(flowLayoutHotels.Controls.Count == 0)
            {
                MessageBox.Show("No hotels match to your filter");
            }

        }
        #endregion
    }
}
