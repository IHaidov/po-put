using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_PRO.Classes
{
    public enum Room_Type
    {
        Lux_2_persons,
        Lux_1_person,
        Normal_2_persons,
        Normal_1_person
    }
    [Serializable]
    public class Room
    {
        public string ID { get; }
        public Room_Type Type { get; set; }
        public double Price { get; set; }
        public bool Free_or_no { get; set; }
    }
}
