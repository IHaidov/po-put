using System;
using System.Collections.Generic;
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

        private readonly List<Address> addresses = new List<Address>();
        private readonly List<Bonus> bonuses = new List<Bonus>();
        private Dictionary<string, string> db_string = new Dictionary<string, string>();
        private readonly List<Hotel> hotels = new List<Hotel>();
        private readonly List<Order> orders = new List<Order>();
        private readonly List<Room> rooms = new List<Room>();
        private readonly List<Person> users = new List<Person>();
        private readonly Person user_credit = new Person();
        private readonly Hotel hotel_credit;
        private readonly Bonus bonus_credit;
        private readonly Room room_credit;
        private readonly Order order_credit;
        private readonly Address address_credit;

        public AdminForm()
        {
            InitializeComponent();
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

                //users.Add(null);
                //addresses.Add(new Address());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void comboBox_Index_Changed()
        {
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}