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

namespace PO_PRO.Forms.UserChildForms
{
    public partial class Profile : Form
    {
        public Person user;
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(string key)
        {
            InitializeComponent();
            string temp;
            DB.Read(key, out temp);
            user = JsonConvert.DeserializeObject<Person>(temp);
            txt_box_Email.Text = user.Email;
            txt_box_Name_Surname.Text = user.Name + " " + user.Surname;
            txt_box_Phone.Text = user.Phone;
            txt_box_Passport.Text = user.Passport_ID;
            txt_box_Username.Text = user.Username;
        }

        public void Submit_changes(Person user)
        {
            
            try
            {
                if (DB.Key_exist(user.Email.ToLower()))
                {
                    DB.Delete_key(user.Email.ToLower());
                    DB.Write(user.Email.ToLower(), JsonConvert.SerializeObject(user));
                    MessageBox.Show("Successfully changed in DB");
                }
                else
                {
                    DB.Write(user.Email.ToLower(), JsonConvert.SerializeObject(user));
                    MessageBox.Show("Successfully changed in DB");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            user.Username = txt_box_Username.Text;
            Submit_changes(user);
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            user.Email = txt_box_Email.Text;
            DB.Delete_key(txt_box_Email.Text.ToLower());
            Submit_changes(user);
        }

        private void btnChangeNameSurname_Click(object sender, EventArgs e)
        {
            user.Name = txt_box_Name_Surname.Text.Split(' ')[0].ToString();
            user.Surname = txt_box_Name_Surname.Text.Split(' ')[1].ToString();
            Submit_changes(user);
        }

        private void btnChangePhone_Click(object sender, EventArgs e)
        {
            user.Phone = txt_box_Phone.Text;
            Submit_changes(user);
        }

        private void btnChangePassport_Click(object sender, EventArgs e)
        {
            user.Passport_ID = txt_box_Passport.Text;
            Submit_changes(user);
        }

        private void txt_box_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            user.Password = txt_box_Password.Text;
            Submit_changes(user);
        }
    }
}
