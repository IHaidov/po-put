using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Newtonsoft.Json;
using PO_PRO.Classes;

namespace PO_PRO.Forms
{
    public partial class AdminForm : Form
    {
        List<Person> users = new List<Person>();
        List<Hotel> hotels = new List<Hotel>();
        List<Order> orders = new List<Order>();
        List<Bonus> bonuses = new List<Bonus>();
        List<Room> rooms = new List<Room>();
        List<Address> adresses = new List<Address>();
        public enum classes
        {
            Address,
            Bonus,
            Hotel,
            Order,
            Person,
            Room
        }
       
        public AdminForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(classes)); 

            List<string> db_string;
            DB.ReadAll(out db_string);
           
            foreach (var db_elem in db_string)
            {
                if (db_elem.Contains("ADDR_"))
                {
                    users.Add(JsonConvert.DeserializeObject<Person>(db_elem));
                }
                else if (db_elem.Contains("BON_"))
                {
                    bonuses.Add(JsonConvert.DeserializeObject<Bonus>(db_elem));
                }
                else if (db_elem.Contains("HOT_"))
                {
                    hotels.Add(JsonConvert.DeserializeObject<Hotel>(db_elem));
                }
                else if (db_elem.Contains("ORD_"))
                {
                    orders.Add(JsonConvert.DeserializeObject<Order>(db_elem));
                }
                else if (db_elem.Contains("ROOM_"))
                {
                    rooms.Add(JsonConvert.DeserializeObject<Room>(db_elem));
                }
                else
                {
                    users.Add(JsonConvert.DeserializeObject<Person>(db_elem));
                }
                
                 
            }

            switch (comboBox1.SelectedIndex)
            {
                case (int)classes.Address:
                    dataGridView1.DataSource = adresses;
                    break;
                case (int)classes.Hotel:
                    dataGridView1.DataSource = hotels;
                    break;
                case (int)classes.Order:
                    dataGridView1.DataSource = orders;
                    break;
                case (int)classes.Bonus:
                    dataGridView1.DataSource = bonuses;
                    break;
                case (int)classes.Room:
                    dataGridView1.DataSource = rooms;
                    break;
                case (int)classes.Person:
                    dataGridView1.DataSource = users;
                    break;
            }



        }
       
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case (int)classes.Address:
                    dataGridView1.DataSource = adresses;
                    break;
                case (int)classes.Hotel:
                    dataGridView1.DataSource = hotels;
                    break;
                case (int)classes.Order:
                    dataGridView1.DataSource = orders;
                    break;
                case (int)classes.Bonus:
                    dataGridView1.DataSource = bonuses;
                    break;
                case (int)classes.Room:
                    dataGridView1.DataSource = rooms;
                    break;
                case (int)classes.Person:
                    dataGridView1.DataSource = users;
                    break;
            }
        }
    }
}
