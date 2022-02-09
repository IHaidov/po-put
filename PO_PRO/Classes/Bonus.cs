using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_PRO.Classes
{
    [Serializable]
    public class Bonus
    {
        public string ID { get; }
        public string Hotel_ID { get; }
        public int Price { get; set; }

        
    }
}
