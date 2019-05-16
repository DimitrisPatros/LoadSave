using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BasketManagment
{
    public class TxtSerializer : ISerializer
    {
        public Basket ReadFromFile(string fileName)
        {
            //Create new basket
            var basket = new Basket();
            try
            {
                foreach (var line in File.ReadAllLines($@"{fileName}.txt"))
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        var item = line.Split(":");
                        var id = int.Parse(item[0]);
                        var name = item[1];
                        var Price = decimal.Parse(item[2]);
                        var category = Enum.Parse<ProductCategoryId>(item[3]);
                        basket.Cart.Add(new Product());
                    }
                }
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
                using (StreamWriter file = new StreamWriter($@"{fileName}.txt"))
                {
                    foreach (Product p in basket.Cart)
                    {
                        file.WriteLine(p.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}

