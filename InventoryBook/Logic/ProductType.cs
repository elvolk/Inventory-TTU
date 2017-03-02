using InventoryBook.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBook.Logic
{
   public class ProductType : BaseList<InventoryItem>
    {
        public static ProductType Instance { get; } = new ProductType();
        
        {
            

        }
    }
}
