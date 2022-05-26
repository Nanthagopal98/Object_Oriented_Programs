using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class inventoryManagement
{
    inventoryModel model = new inventoryModel();
    inventoryList inventory = new inventoryList();
    List<inventoryList> inventorylist = new List<inventoryList>();
    List<inventoryModel> Rice;
    List<inventoryModel> Pulse;
    List<inventoryModel> Wheat;
    public void group(string jsonFilePath)
    {
        using(StreamReader reader = new StreamReader(jsonFilePath))
        {
            var json = reader.ReadToEnd();
            inventoryList items = JsonConvert.DeserializeObject<inventoryList>(json);
            Rice = items.Rice;
            Pulse = items.Pulse;
            Wheat = items.Wheat;
            Console.WriteLine("Enter 1 for Rice");
            Console.WriteLine("Enter 2 for Pulse");
            Console.WriteLine("Enter 3 for Wheat");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    foreach(inventoryModel print in Rice)
                    Console.WriteLine(print.Name + " " +print.price + " " +print.weight);
                    break;
                case 2:
                    foreach (inventoryModel print in Pulse)
                        Console.WriteLine(print.Name + " " + print.price + " " + print.weight);
                    break;
                case 3:
                    foreach (inventoryModel print in Wheat)
                        Console.WriteLine(print.Name + " " + print.price + " " + print.weight);
                    break;
            }
        }
    }
}

