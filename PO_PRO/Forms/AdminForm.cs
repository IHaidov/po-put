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

            List<string> users_string;
            DB.ReadAll(out users_string);
            List<Person> users = new List<Person>();
            foreach (var user in users_string)
            {
                
                 users.Add(JsonConvert.DeserializeObject<Person>(user));
                 
            }

            dataGridView1.DataSource = users;

        }
       
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
