using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryBook.Logic;

namespace InventoryBook.Logic
{
    public class Product
    {
        public Product(string ItemName, int quantity, int ItemId, string ItemCategory, int InventoryId, string Description, double InventoryStatus, DateTime ProductValidUntil)
        {
            
            List<Product> ProductList = new List<Product>();

            ProductList.Add(new Product("ItemName", 10, 1265, "TOOTED1", 667, "Hea toode", 1,new DateTime(2017, 03, 03)));

            foreach(var Product in ProductList)
            {
                //Näidata seda kuskil
            }
        }
    }
}
