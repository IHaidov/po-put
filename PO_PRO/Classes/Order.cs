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
        private string ID { get; set; }
        public DateTime Date_of_Reservation { get; set; }
        public double Price { get; set; }
        private string User_ID { get; set; }
        private string Hotel_ID { get; set; }
        private string Room_ID { get; set; }
        public string Bonus_ID { get; set; }

        public string GetID()
        {
            return ID;
        }
    }
}
