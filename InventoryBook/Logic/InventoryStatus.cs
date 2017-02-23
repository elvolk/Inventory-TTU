using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBook.Logic
{
   public class InventoryStatus
    {
        public enum InventoryStatus
        {
            PastStorage = 0,
            CurrentInventory = 1,
            Processing = 15,
            Unknown = 99 
        }
    }
}
