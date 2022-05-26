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
            json.group(@"D:\Bridgelabz\.Net\Object_Oriented_Programs\JSON Inventory Management\JSON Inventory Management\Inventory.json");

            //stockManagement manage = new stockManagement();
            //manage.convert(@"D:\Bridgelabz\.Net\Object_Oriented_Programs\JSON Inventory Management\JSON Inventory Management\syock.json");
        }
    }
}
