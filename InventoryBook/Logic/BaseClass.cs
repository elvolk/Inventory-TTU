using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBook.Logic
{
    public class BaseClass
    {
        public void SetValue<T>(ref T field, T value)
        {
            field = value;
        }
    }
}
