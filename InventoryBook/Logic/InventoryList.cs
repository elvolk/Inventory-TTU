using System.Collections.Generic;

namespace InventoryBook.Logic
{
    public class Product
    {
        public Product(string ItemName, int quantity, int ItemId, string ItemCategory, int InventoryId, string Description, double InventoryStatus)
        {
            
            List<Product> ProductList = new List<Product>();

            ProductList.Add(new Product("ItemName", 10, 1265, "TOOTED1", 667, "Hea toode", 1));

            foreach(var Product in ProductList)
            {
                //Näidata seda kuskil
            }
        }
    }
}
