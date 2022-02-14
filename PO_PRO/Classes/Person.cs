using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_PRO.Classes
{
    public enum Type
    {
        Admin,
        Owner,
        User,
        Accountant
    }
    [Serializable]
    public class Person
    {
        public string ID { get; set; }
        public Type User_Type { get; set; }
        public string Name { get; set; }
        
        
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Passport_ID { get; set; }
        public DateTime BirthTime { get; set; }
        public bool Blocked { get; set; }

        public Person()
        {
            ID = Guid.NewGuid().ToString();
            User_Type = Type.User;
            BirthTime = DateTime.Now;
            Blocked = false;
        }
    }
}
