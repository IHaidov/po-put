using System;
using System.Collections.Generic;
using System.Drawing;

namespace PO_PRO.Classes
{
    [Serializable]
    public class Hotel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Bonus> Facilities { get; set; }
        public Address Address { get; set; }
       // public Image Photo { get; set; }
        public string Info { get; set; }
        public string Owner { get; set; }

        public Hotel()
        {
            ID = Guid.NewGuid().ToString();
            Facilities = new List<Bonus>();
            Rooms = new List<Room>();
            Address = new Address();
        }
    }
}