using System;
using System.Collections.Generic;
using System.Drawing;

namespace PO_PRO.Classes
{
    [Serializable]
    public class Hotel :IHotel
    {
        private string ID { get; set; }
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

        public string GetID()
        {
            return ID;
        }

        public Address getAddress()
        {
            return Address;
        }

        public void setAddress(Address address)
        {
            this.Address = address;
        }

        public void addRooms(List<Room> rooms)
        {
            this.Rooms = rooms;
        }

        public List<Room> getRooms()
        {
            return Rooms;
        }

        public void setOwner(string Owner)
        {
            this.Owner = Owner;
        }
    }
}