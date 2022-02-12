using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_PRO.Classes
{
    [Serializable]
    public class Address
    {
        public string ID { get; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal_Code { get; set; }
        public string Country { get; set; }
        public Address()
        {
            ID = Guid.NewGuid().ToString();
           
        }
    }
}
