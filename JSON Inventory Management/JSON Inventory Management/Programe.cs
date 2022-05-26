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
            Console.Write("Enter 1 to run Food inventory\n");
            Console.Write("Enter 2 to run Stock inventory");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    inventoryManagement json = new inventoryManagement();
                    json.group(@"D:\Bridgelabz\.Net\Object_Oriented_Programs\JSON Inventory Management\JSON Inventory Management\Inventory.json");
                    break;
                case 2:
                    stockManagement manage = new stockManagement();
                    manage.convert(@"D:\Bridgelabz\.Net\Object_Oriented_Programs\JSON Inventory Management\JSON Inventory Management\syock.json");
                    break;
            }
        }
    }
}
