using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_PRO.Classes
{
   [Serializable]
    public class Order
    {
        public int ID { get; }
        public DateTime Date_of_Reservation { get; set; }
        public double Price { get; set; }
        private int User_ID { get; set; }
        private int Hotel_ID { get; set; }
        private int Room_ID { get; set; }
        public int Bonus_ID { get; set; }

    }
}
