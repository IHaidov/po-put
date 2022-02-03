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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(string key)
        {
            InitializeComponent();
            string temp;
            DB.Read(key, out temp);
            Person user = JsonConvert.DeserializeObject<Person>(temp);
           
        }
       
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
