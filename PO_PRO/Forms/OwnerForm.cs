using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PO_PRO.Classes;

namespace PO_PRO.Forms
{
    public partial class OwnerForm : Form
    {

        private Dictionary<string, string> db_string = new Dictionary<string, string>();
        private List<Hotel> hotels = new List<Hotel>();

        private int editIndex = -1;

        private List<Hotel> hotel_credit = new List<Hotel>();
        private List<Room> room_credit = new List<Room>();
        private List<Bonus> facilities = new List<Bonus>();

        public OwnerForm(string ID)
        {
            InitializeComponent();
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Edit";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            dataGridView1.Columns.Add(Editlink);

            //Delete link

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dataGridView1.Columns.Add(Deletelink);

            room_credit.Add(new Room());
            hotel_credit.Add(new Hotel());

            facilities.Add(new Bonus(Bonus_Type.Kitchen));
            facilities.Add(new Bonus(Bonus_Type.Free_WiFi));
            facilities.Add(new Bonus(Bonus_Type.Parking));
            facilities.Add(new Bonus(Bonus_Type.Pets_allowed));
            facilities.Add(new Bonus(Bonus_Type.Fitness_centre));
            facilities.Add(new Bonus(Bonus_Type.Electric_kettle));
            facilities.Add(new Bonus(Bonus_Type.TV));

            foreach (var facility in facilities)
            {
                facilitiesCheckBox.Items.Add(facility.Type);
            }


            roomComboBox.DataSource = Enum.GetValues(typeof(Room_Type));

            dbUpdate();
        }
        public OwnerForm()
        {
            InitializeComponent();
           
            dbUpdate();
        }

        public string KeyMaker(string ID)
        {
            return "HOT_" + ID;
        }

        public void ListKeyDelete(string id)
        {
            var elem = hotels.SingleOrDefault(r => r.ID == id);
            hotels.Remove(elem);
            dataGridView1.DataSource = hotels;
        }



        private void OwnerForm_Load(object sender, EventArgs e)
        {
        }
        public void dbUpdate()
        {
            try
            {
                db_string = new Dictionary<string, string>();
                dataGridView1.DataSource = null;
                hotels.Clear();
                DB.ReadAll(out db_string);
                foreach (var db_elem in db_string)
                {
                    if (db_elem.Key.Contains("HOT_"))
                    {
                        hotels.Add((new Hotel()));
                        hotels[hotels.Count - 1] = JsonConvert.DeserializeObject<Hotel>(db_elem.Value);
                    }
                }

                dataGridView1.DataSource = hotels;
            }
            catch (Exception ex)
            {
                MessageBox.Show("!!!!!" + ex);
                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Hotel_Operations

        public void editHotel()
        {
            hotelInfo.Text = hotels[editIndex].Info;
            hotelName.Text = hotels[editIndex].Info;
            // hotelPicture.Image = hotels[editIndex].Info;
            starsNumeric.Text = hotels[editIndex].Info;
            streetText.Text = hotels[editIndex].Info;
            cityText.Text = hotels[editIndex].Info;
            stateText.Text = hotels[editIndex].Info;
            postalCodeText.Text = hotels[editIndex].Info;
            countryText.Text = hotels[editIndex].Info; 
            //roomComboBox.SelectedIndex = hotels[editIndex].Info;
            roomNumeric.Text = hotels[editIndex].Info;
            foreach (object facilityChecked in facilitiesCheckBox.Items)
            {
                //      facilitiesCheckBox.CheckedItems.
                //      hotel_credit[0].Facilities.Add(b);
            }
            if (roomFreeRadioBtn.Checked)
                room_credit[0].Free_Room = true;
            else
            {
                room_credit[0].Free_Room = false;
            }

            for (int i = 0; i < Convert.ToDouble(roomAmountnumeric.Text); i++)
            {
                hotel_credit[0].Rooms.Add(room_credit[0]);
            }
        }
        public void addHotel()
        {
            hotel_credit[0].Info = hotelInfo.Text;
            hotel_credit[0].Name = hotelName.Text;
            //hotel_credit[0].Photo = (Image)hotelPicture.Image;
            hotel_credit[0].Stars = Convert.ToInt32(starsNumeric.Text);
            hotel_credit[0].Address.Street = streetText.Text;
            hotel_credit[0].Address.City = cityText.Text;
            hotel_credit[0].Address.State = stateText.Text;
            hotel_credit[0].Address.Postal_Code = postalCodeText.Text;
            hotel_credit[0].Address.Country = countryText.Text;
            room_credit[0].Type = (Room_Type)Convert.ToInt32(roomComboBox.SelectedIndex);
            room_credit[0].Price = Convert.ToDouble(roomNumeric.Text);
            foreach (object facilityChecked in facilitiesCheckBox.CheckedItems)
            {
                Bonus b = new Bonus((Bonus_Type)facilityChecked);
                hotel_credit[0].Facilities.Add(b);
            }
            if (roomFreeRadioBtn.Checked)
                room_credit[0].Free_Room = true;
            else
            {
                room_credit[0].Free_Room = false;
            }

            for (int i = 0; i < Convert.ToDouble(roomAmountnumeric.Text); i++)
            {
                hotel_credit[0].Rooms.Add(room_credit[0]);
            }
        }
        public void clearHotel()
        {
            hotelInfo.Text = "";
            hotelName.Text = "";
            hotelPicture.Image = null;
            starsNumeric.Text = "";
            streetText.Text = "";
            cityText.Text = "";
            stateText.Text = "";
            postalCodeText.Text = "";
            countryText.Text = "";
            roomComboBox.SelectedIndex = 0;
            roomNumeric.Text = "";
            foreach (object facilityChecked in facilitiesCheckBox.CheckedItems)
            {
                Bonus b = new Bonus((Bonus_Type)facilityChecked);
                hotel_credit[0].Facilities.Add(b);
            }
            if (roomFreeRadioBtn.Checked)
                room_credit[0].Free_Room = true;
            else
            {
                room_credit[0].Free_Room = false;
            }

            for (int i = 0; i < Convert.ToDouble(roomAmountnumeric.Text); i++)
            {
                hotel_credit[0].Rooms.Add(room_credit[0]);
            }
        }
        #endregion


        private void btnSubmit_Click(object sender, EventArgs e)
        {

           
                    try
                    {
                        addHotel();
                        DB.Write("HOT_" + hotel_credit[0].ID, JsonConvert.SerializeObject(hotel_credit[0]));

                        dataGridView1.DataSource = null;
                        if (editIndex > -1)
                        {
                            hotels.RemoveAt(editIndex);
                            hotels.Add(hotel_credit[0]);
                        }
                        else hotels.Add(hotel_credit[0]);

                        dbUpdate();
                        dataGridView1.DataSource = hotels;
                        hotelTab.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

            dataGridView1.Update();
            dataGridView1.Refresh();
            editIndex = -1;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //edit column 
            if (e.ColumnIndex == 0)
            {
                editIndex = e.RowIndex;

                hotelTab.Visible = true;

                
                dataGridView1.Refresh();

            } //delete column

            if (e.ColumnIndex == 1)
            {
               
                {
                    try
                    {

                        DB.Delete_key(KeyMaker(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()));
                        ListKeyDelete(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        throw;
                    }
                }

                dbUpdate();
                dataGridView1.Refresh();
            }

        }
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            dbUpdate();
           
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        { 
            hotel_credit.Clear();
            clearHotel();
            //hotel_credit.Add(new Hotel());
            hotelTab.Visible = true;
            btnSubmit.Visible = true;

        }

        private void roomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
