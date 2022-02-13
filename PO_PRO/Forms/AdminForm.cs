using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using PO_PRO.Classes;

namespace PO_PRO.Forms
{
    public partial class AdminForm : Form
    {
        public enum classes
        {
            Address,
            Bonus,
            Hotel,
            Order,
            Person,
            Room
        }

        private bool createClicked = false, editClicked = false, deleteClicked = false;
        
        private readonly List<Address> addresses = new List<Address>();
        private readonly List<Bonus> bonuses = new List<Bonus>();
        private Dictionary<string, string> db_string = new Dictionary<string, string>();
        private readonly List<Hotel> hotels = new List<Hotel>();
        private readonly List<Order> orders = new List<Order>();
        private readonly List<Room> rooms = new List<Room>();
        private readonly List<Person> users = new List<Person>();

        private readonly List<Person> user_credit = new List<Person>();
        private readonly List<Hotel> hotel_credit = new List<Hotel>();
        private readonly List<Bonus> bonus_credit = new List<Bonus>();
        private readonly List<Room> room_credit = new List<Room>();
        private readonly List<Order> order_credit = new List<Order>();
        private readonly List<Bonus> facilities = new List<Bonus>();
        private readonly List<Address> address_credit = new List<Address>();

        public AdminForm()
        {
            InitializeComponent();
            
            //Edit link 

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

            address_credit.Add(new Address());
            hotel_credit.Add(new Hotel());
            order_credit.Add(new Order());
            bonus_credit.Add(new Bonus());
            room_credit.Add(new Room());
            user_credit.Add(new Person());
            
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
           

            comboBox_Index_Changed();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(classes));
            dbUpdate();

            comboBox_Index_Changed();
        }

        public void dbUpdate()
        {
            try
            {
                db_string.Clear();
                DB.ReadAll(out db_string);
                
                foreach (var db_elem in db_string)
                    
                    if (db_elem.Key.Contains("ADDR_"))
                        addresses.Add(JsonConvert.DeserializeObject<Address>(db_elem.Value));
                    else if (db_elem.Key.Contains("BON_"))
                        bonuses.Add(JsonConvert.DeserializeObject<Bonus>(db_elem.Value));
                    else if (db_elem.Key.Contains("HOT_"))
                        hotels.Add(JsonConvert.DeserializeObject<Hotel>(db_elem.Value));
                    else if (db_elem.Key.Contains("ORD_"))
                        orders.Add(JsonConvert.DeserializeObject<Order>(db_elem.Value));
                    else if (db_elem.Key.Contains("ROOM_"))
                        rooms.Add(JsonConvert.DeserializeObject<Room>(db_elem.Value));
                    else if (db_elem.Key.Contains("@"))
                        users.Add(JsonConvert.DeserializeObject<Person>(db_elem.Value));

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("!!!!!"+ex);
                throw;
            }
        }

        private void comboBox_Index_Changed()
        {
            roomPanel.Visible = false;
            hotelPanel.Visible = false;
            bonusPanel.Visible = false;
            dataGridView2.Visible = false;

            switch (comboBox1.SelectedIndex)
            {
                case (int) classes.Address:
                    dataGridView1.DataSource = addresses;
                    
                    dataGridView2.DataSource = address_credit;
                    break;
                case (int) classes.Hotel:
                    dataGridView1.DataSource = hotels;
                    
                    dataGridView2.DataSource = hotel_credit;
                    break;
                case (int) classes.Order:
                    dataGridView1.DataSource = orders;
                    
                    dataGridView2.DataSource = order_credit;
                    break;
                case (int) classes.Bonus:
                    dataGridView1.DataSource = bonuses;
                    
                    dataGridView2.DataSource = bonus_credit;
                    break;
                case (int) classes.Room:
                    dataGridView1.DataSource = rooms;
                   
                    dataGridView2.DataSource = room_credit;
                    break;
                case (int) classes.Person:
                    dataGridView1.DataSource = users;
                    
                    dataGridView2.DataSource = user_credit;
                    break;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Index_Changed();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click (object sender, EventArgs e)
        {
            editClicked = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteClicked = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case (int)classes.Address:
                   address_credit[0].Street = dataGridView2.Rows[0].Cells[1].Value.ToString();
                   address_credit[0].City = dataGridView2.Rows[0].Cells[2].Value.ToString();
                   address_credit[0].State = dataGridView2.Rows[0].Cells[3].Value.ToString();
                   address_credit[0].Postal_Code = dataGridView2.Rows[0].Cells[4].Value.ToString();
                   address_credit[0].Country = dataGridView2.Rows[0].Cells[5].Value.ToString();
                   
                    try
                    {
                        DB.Write("ADDR_"+address_credit[0].ID, JsonConvert.SerializeObject(address_credit[0]));
                        addresses.Add(address_credit[0]);
                        dataGridView1.DataSource = addresses;
                        dataGridView2.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case (int)classes.Hotel:
                    hotel_credit[0].Name = hotelName.Text;
                    hotel_credit[0].Stars = Convert.ToInt32(starsNumeric.Text);
                    try
                    {
                        DB.Write("HOT_" + address_credit[0].ID, JsonConvert.SerializeObject(hotel_credit[0]));
                        hotels.Add(hotel_credit[0]);
                        dataGridView1.DataSource = hotels;
                        hotelPanel.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case (int)classes.Order:
                   
                    break;

                case (int)classes.Bonus:
                    bonus_credit[0].Type = (Bonus_Type)Convert.ToInt32(bonusComboBox.SelectedIndex);
                    bonus_credit[0].Price = Convert.ToDouble(bonusNumeric.Text);

                    try
                    {
                        DB.Write("BON_" + bonus_credit[0].ID, JsonConvert.SerializeObject(bonus_credit[0]));
                        bonuses.Add(bonus_credit[0]);
                        dataGridView1.DataSource = bonuses;
                        bonusPanel.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case (int)classes.Room:
                    room_credit[0].Type = (Room_Type)Convert.ToInt32(roomComboBox.SelectedIndex);
                    room_credit[0].Price = Convert.ToDouble(roomNumeric.Text);
                    foreach (object facilityChecked in facilitiesCheckBox.CheckedItems)
                    {
                        Bonus b = new Bonus((Bonus_Type)facilityChecked);
                        room_credit[0].Facilities.Add(b);
                    }
                    if(roomFreeRadioBtn.Checked)
                        room_credit[0].Free_Room = true;
                    else
                    {
                        room_credit[0].Free_Room = false;
                    }

                    try
                    {
                        DB.Write("ROOM_" + room_credit[0].ID, JsonConvert.SerializeObject(room_credit[0]));
                        rooms.Add(room_credit[0]);
                        dataGridView1.DataSource = rooms;
                        roomPanel.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case (int)classes.Person:
                    user_credit[0].Name = dataGridView2.Rows[0].Cells[2].Value.ToString();
                    user_credit[0].Surname = dataGridView2.Rows[0].Cells[3].Value.ToString();
                    user_credit[0].Username = dataGridView2.Rows[0].Cells[4].Value.ToString();
                    user_credit[0].Email = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    user_credit[0].Password = dataGridView2.Rows[0].Cells[6].Value.ToString();
                    user_credit[0].Phone = dataGridView2.Rows[0].Cells[7].Value.ToString();
                    user_credit[0].Passport_ID = dataGridView2.Rows[0].Cells[8].Value.ToString();
                    try
                    {
                        DB.Write(user_credit[0].Email.ToLower(), JsonConvert.SerializeObject(user_credit[0]));
                        users.Add(user_credit[0]);
                        dataGridView1.DataSource = users;
                        dataGridView2.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;
            }
            dbUpdate();
            comboBox_Index_Changed();
            dataGridView1.Update();
            dataGridView1.Refresh();
            
        }

        private void panelNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //edit column 
            if (e.ColumnIndex == 0)
            {

                dataGridView1.Refresh();

            } //delete column

            if (e.ColumnIndex == 1)
            {
                dataGridView1.Refresh();
            }
            
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Tab && dataGridView1.CurrentCell.ColumnIndex == 1)
            //{
            //    e.Handled = true;
            //    DataGridViewCell cell = dataGridView2.Rows[0].Cells[0];
            //    dataGridView1.CurrentCell = cell;
            //    dataGridView1.BeginEdit(true);
            //}
            dataGridView2.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView2.RefreshEdit();
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Refresh();
        }

        private void facilitiesCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            createClicked = true;
            switch (comboBox1.SelectedIndex)
            {
                case (int)classes.Address:
                    address_credit.Clear();
                    address_credit.Add(new Address());
                    dataGridView2.Visible = true;
                    break;
                case (int)classes.Hotel:
                    hotel_credit.Clear();
                    hotel_credit.Add(new Hotel());
                    hotelPanel.Visible = true;
                    break;
                case (int)classes.Order:
                   
                    break;
                case (int)classes.Bonus:
                    bonus_credit.Clear();
                    bonus_credit.Add(new Bonus());
                    bonusPanel.Visible = true;
                    bonusComboBox.DataSource = Enum.GetValues(typeof(Bonus_Type)); 
                    break;
                case (int)classes.Room:
                    room_credit.Clear();
                    room_credit.Add(new Room());
                    roomPanel.Visible = true;
                    roomComboBox.DataSource = Enum.GetValues(typeof(Room_Type));
                    break;
                case (int)classes.Person:
                    user_credit.Clear();
                    user_credit.Add(new Person());
                    dataGridView2.Visible = true;
                    break;
            }
           
            btnSubmit.Visible = true;
            
        }
    }
}