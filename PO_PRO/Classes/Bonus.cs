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
        public int ID { get; }
        public int Hotel_ID { get; }
        public int Price { get; set; }

        
    }
}
