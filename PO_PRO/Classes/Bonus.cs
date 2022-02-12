using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_PRO.Classes
{
    public enum Bonus_Type
    {
        Kitchen,
        Free_WiFi,
        Parking,
        Pets_allowed,
        Fitness_centre,
        Electric_kettle,
        TV
    }
    [Serializable]
    public class Bonus
    {
        public string ID { get; }
        public Bonus_Type Type { get; set; }
        public double Price { get; set; }
        public Bonus()
        {
            ID = Guid.NewGuid().ToString();
        }

    }
}
