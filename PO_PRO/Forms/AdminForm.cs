using System;
using System.Collections.Generic;
using System.Drawing;
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
            _,
            Hotel,
            Order,
            Person
            
        }
        private bool createClicked = false, editClicked = false, deleteClicked = false;
        
        private  List<Address> addresses = new List<Address>();
        private  List<Bonus> bonuses = new List<Bonus>();
        private Dictionary<string, string> db_string = new Dictionary<string, string>();
        private  List<Hotel> hotels = new List<Hotel>();
        private  List<Order> orders = new List<Order>();
        private  List<Room> rooms = new List<Room>();
        private  List<Person> users = new List<Person>();

        private  List<Person> user_credit = new List<Person>();
        private  List<Hotel> hotel_credit = new List<Hotel>();
        private  List<Bonus> bonus_credit = new List<Bonus>();
        private  List<Room> room_credit = new List<Room>();
        private  List<Order> order_credit = new List<Order>();
        private  List<Bonus> facilities = new List<Bonus>();
        private  List<Address> address_credit = new List<Address>();

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

        public string KeyMaker(string ID)
        {
            switch (comboBox1.SelectedIndex)
            {
               
                case (int)classes.Hotel:
                    return "HOT_"+ID;
                    break;
                case (int)classes.Order:
                    return "ORD_" + ID;
                    break;
               
                case (int)classes.Person:
                    return ID;
                    break;
                
            }

            return "";
        }
        public void ListKeyDelete(string id)
        {
            dataGridView1.DataSource = null;
            switch (comboBox1.SelectedIndex)
            {

                case (int)classes.Hotel:
                    
                    var elem = hotels.SingleOrDefault(r => r.ID == id);
                    hotels.Remove(elem);
                    dataGridView1.DataSource = hotels;
                    
                    break;
                case (int)classes.Order:
                    var elem1 = orders.SingleOrDefault(r => r.ID == id);
                    orders.Remove(elem1);
                    dataGridView1.DataSource = orders;
                    break;

                case (int)classes.Person:
                    var elem2 = users.SingleOrDefault(r => r.ID == id);
                    users.Remove(elem2);
                    dataGridView1.DataSource = users;
                    break;

            }

           
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(classes));
            roomComboBox.DataSource = Enum.GetValues(typeof(Room_Type));
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
                    {
                        
                        addresses.Add(JsonConvert.DeserializeObject<Address>(db_elem.Value));
                    }
                    else if (db_elem.Key.Contains("BON_"))
                        bonuses.Add(JsonConvert.DeserializeObject<Bonus>(db_elem.Value));
                    else if (db_elem.Key.Contains("HOT_"))
                    {
                        hotels.Add((new Hotel()));
                        hotels[hotels.Count - 1] = JsonConvert.DeserializeObject<Hotel>(db_elem.Value);
                        
                    }
                    else if (db_elem.Key.Contains("ORD_"))
                        orders.Add(JsonConvert.DeserializeObject<Order>(db_elem.Value));
                    else if (db_elem.Key.Contains("ROOM_"))
                        rooms.Add(JsonConvert.DeserializeObject<Room>(db_elem.Value));
                    else if (db_elem.Key.Contains("@"))
                    {
                        users.Add((new Person()));
                        
                        Person usr = JsonConvert.DeserializeObject<Person>(db_elem.Value);
                        
                        users[users.Count - 1] = JsonConvert.DeserializeObject<Person>(db_elem.Value);
                    }


            }
            catch (Exception ex)
            {
                Console.WriteLine("!!!!!"+ex);
                throw;
            }
        }

        private void comboBox_Index_Changed()
        {
            
            hotelTab.Visible = false;
            bonusPanel.Visible = false;
            dataGridView2.Visible = false;

            switch (comboBox1.SelectedIndex)
            {
               
                case (int) classes.Hotel:
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = hotels;
                    
                    dataGridView2.DataSource = hotel_credit;
                    break;
                case (int) classes.Order:
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = orders;
                    
                    dataGridView2.DataSource = order_credit;
                    break;
              
                case (int) classes.Person:
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = users;
                    
                    dataGridView2.DataSource = user_credit;
                    break;
                case (int)classes._:
                    dataGridView1.DataSource = null;

                    dataGridView2.DataSource = null;
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

        public void addHotel()
        {
            hotel_credit[0].Info = hotelInfo.Text;
            hotel_credit[0].Name = hotelName.Text;
            hotel_credit[0].Photo = hotelPicture.Image;
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Height -= 200;
            switch (comboBox1.SelectedIndex)
            {
               

                case (int)classes.Hotel:
                   
                    try
                    {
                        addHotel();
                        DB.Write("HOT_" + hotel_credit[0].ID, JsonConvert.SerializeObject(hotel_credit[0]));
                        hotels.Add(hotel_credit[0]);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = hotels;
                        hotelTab.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case (int)classes.Order:
                   
                    break;

               
                case (int)classes.Person:
                    user_credit[0].Name = dataGridView2.Rows[0].Cells[2].Value.ToString();
                    user_credit[0].Surname = dataGridView2.Rows[0].Cells[3].Value.ToString();
                    user_credit[0].Username = dataGridView2.Rows[0].Cells[4].Value.ToString();
                    user_credit[0].Email = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    user_credit[0].Password = dataGridView2.Rows[0].Cells[6].Value.ToString();
                    user_credit[0].Phone = dataGridView2.Rows[0].Cells[7].Value.ToString();
                    user_credit[0].Passport_ID = dataGridView2.Rows[0].Cells[8].Value.ToString();
                    user_credit[0].Blocked = Convert.ToBoolean(dataGridView2.Rows[0].Cells[10].Value.ToString());
                    try
                    {
                        DB.Write(user_credit[0].Email.ToLower(), JsonConvert.SerializeObject(user_credit[0]));
                        users.Add(user_credit[0]);
                        dataGridView1.DataSource = null;
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
                if (comboBox1.SelectedIndex == (int)classes.Person)
                {
                    
                }
                else
                {
                    hotelTab.Visible = true;
                }
                dataGridView1.Refresh();

            } //delete column

            if (e.ColumnIndex == 1)
            {
                if (comboBox1.SelectedIndex == (int) classes.Person)
                {
                    try
                    {
                        DB.Delete_key(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                        ListKeyDelete(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        throw;
                    }
                    
                }
                else
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

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
           
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

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            dbUpdate();
            comboBox_Index_Changed();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void hotelPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                hotelPicture.Image = new Bitmap(open.FileName);
            }
        }

        private void roomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        Point lastPoint;

        private void AdminForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AdminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Height += 200;
            createClicked = true;
            switch (comboBox1.SelectedIndex)
            { 
                
                case (int)classes.Hotel:
                    hotel_credit.Clear();
                    hotel_credit.Add(new Hotel());
                    hotelTab.Visible = true;
                    break;
                case (int)classes.Order:
                   
                    break;
              
                //    break;
                case (int)classes.Person:
                    hotelTab.Visible = false;
                    user_credit.Clear();
                    user_credit.Add(new Person());
                    dataGridView2.Visible = true;
                    break;
            }
           
            btnSubmit.Visible = true;
            
        }
    }
}