using System;

namespace BasketManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create different type of baskets
            Basket wood = new Basket();

            //Dummy Data for test
            wood.FillWithDummyData();

            //Save in differnt formts
            wood.SaveText("Cart2");
            wood.SaveJson("Cart04");
            wood.SaveExcel("cart22","SheetName");//for saving in excel we have to right the name of the sheet as well 


            //Load from different formats
            wood.LoadText("Cart2");// the separator is ':' with no other things for example 1:puma:89.99:shoes 
            wood.LoadJson("CArt");
            wood.LoadExcel("Cart","Sheet"); // in order for the load excel to work we have to write the name of the sheet too

            wood.PrintList();
        }
    }
}
