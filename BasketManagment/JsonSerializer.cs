using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BasketManagment
{
    public class JsonSerializer : ISerializer
    {
        public Basket ReadFromFile(string fileName)
        {
            //Create new basket
            var basket = new Basket();
            try
            {
                string data = File.ReadAllText($@"{fileName}.json");
                //add products to the list of basket
                basket = JsonConvert.DeserializeObject<Basket>(data);
            }
            catch (Exception e)
            {
                return null;
            }
            return basket;
        }

        public bool SaveToFile(string fileName, Basket basket)
        {
            try
            {
                var jsonData = JsonConvert.SerializeObject(basket, Formatting.None);
                File.WriteAllText($@"{fileName}.json", jsonData);
                //File.WriteAllText($@"C:\Users\patro\Desktop\doc\{fileName}.json", jsonData);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No input name or no data");
                return false;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The directory not found");
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
