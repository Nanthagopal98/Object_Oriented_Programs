using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Inventory_Management
{
    internal class Programe
    {
        public static void Main()
        {
            inventoryManagement json = new inventoryManagement();
            json.group(@"D:\Bridgelabz\.Net\Address-Book\JSON Inventory Management\JSON Inventory Management\Inventory.json");
        }
    }
}
