using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


    internal class stockManagement
    {
        stockModel model = new stockModel();
        List<stockModel> stockList = new List<stockModel>();
        public void convert(string jasonFilePath)
        {
            using (StreamReader reader = new StreamReader(jasonFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<stockModel>>(json);
                foreach(var item in items)
                {
                    Console.WriteLine(item.stockNames +" "+ item.numberOfShare +" "+ item.sharePrice);
                }

            }
        }

    }

