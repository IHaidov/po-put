using System;
using System.Collections.Generic;

namespace PO_PRO.Classes
{
    [Serializable]
    public class Hotel
    {
        public int ID { get; }
        public string Name { get; set; }
        public int Stars { get; set; }
        public List<Room> Rooms { get; set; }
        public Address Address { get; set; }
    }
}