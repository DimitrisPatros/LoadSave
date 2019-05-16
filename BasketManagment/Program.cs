using System;

namespace BasketManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            //new products
            var product01 = new Product(1, "puma", 102.5M, ProductCategoryId.Shoes);
            var product02 = new Product(2, "trusardi", 80M, ProductCategoryId.Shirt);
            //new basket
            var basket01 = new Basket();
            //add product to basket
            basket01.Cart.Add(product01);
            basket01.Cart.Add(product02);

            var txtSerializer = new TxtSerializer();
            //txtSerializer.SaveToFile("basket01", basket01);
            var basket02 = txtSerializer.ReadFromFile("basket01");

            basket02.Cart.ToString();

            foreach (var p in basket02.Cart)
            {
                Console.WriteLine(p);
  
            }


            //var jsonserializer = new JsonSerializer();
            //jsonserializer.SaveToFile("basket01", basket01);
            //var basket = jsonserializer.ReadFromFile("basket01");


            ////create different type of baskets
            //Basket wood = new Basket();

            ////Dummy Data for test
            //wood.FillWithDummyData();

            ////Save in differnt formts
            //wood.SaveText("Cart2");
            //wood.SaveJson("Cart04");
            //wood.SaveExcel("cart22","SheetName");//for saving in excel we have to right the name of the sheet as well 


            ////Load from different formats
            //wood.LoadText("Cart2");// the separator is ':' with no other things for example 1:puma:89.99:shoes 
            //wood.LoadJson("CArt");
            //wood.LoadExcel("Cart","Sheet"); // in order for the load excel to work we have to write the name of the sheet too

            //wood.PrintList();
        }
    }
}
