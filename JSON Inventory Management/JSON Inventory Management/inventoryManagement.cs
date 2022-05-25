using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class inventoryManagement
{
    inventoryModel model = new inventoryModel();
    List<inventoryModel> inventoryList = new List<inventoryModel>();
    public void group(string jsonFilePath)
    {
        using(StreamReader reader = new StreamReader(jsonFilePath))
        {
            var json = reader.ReadToEnd();
            var items = JsonConvert.DeserializeObject<List<inventoryModel>>(json);
            foreach(var item in items)
            {
                Console.WriteLine(item.Name +" "+ item.price +" "+ item.weight);
            }
        }
    }
}

