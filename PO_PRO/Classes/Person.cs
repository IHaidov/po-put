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
    public class Person
    {
        private int ID { get; }
        private Type User_Type { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Passport_ID { get; set; }
        public DateTime BirthTime { get; set; }
        public Address Home_Adress { get; set; }

        public Person()
        {

        }
    }
}
