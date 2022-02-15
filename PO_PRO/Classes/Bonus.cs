using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_PRO.Classes
{
    public enum Bonus_Type
    {
        Electric_kettle,
        Fitness_centre,
        Parking,
        TV,
        Pets_allowed,
        Free_WiFi,
        Balcony,
        Private_bathroom,
        Kitchen
        
    }
    [Serializable]
    public class Bonus
    {
        private string ID { get; set; }
        public Bonus_Type Type { get; set; }
        private double Price { get; set; }
        public Bonus()
        {
            ID = Guid.NewGuid().ToString();
        }
        public Bonus(Bonus_Type fac)
        {
            this.Type = fac;
            ID = Guid.NewGuid().ToString();
        }
    }
}
