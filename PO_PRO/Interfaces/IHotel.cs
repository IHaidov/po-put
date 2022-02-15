using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_PRO.Classes
{
    public interface IHotel
    {
         string GetID();
         Address getAddress();
         void setAddress(Address address);

         void addRooms(List<Room> rooms);
         List<Room> getRooms();

         void setOwner(string Owner);
    }
}
