using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BasketManagment
{
    class Program
    {
        public static void Main(string[] args)
        {
            var context = new OrderManagmentDbContext();

            var baskets = context.Set<Basket>().Include(b => b.Cart).First();

            context.Remove(baskets.Cart.First());

            var totalAmount = context.Set<Product>()
                .Where(p => p.Category==ProductCategoryId.Shoes)
                .Sum(p=> p.Price);
            Console.WriteLine(totalAmount);


            //var Products = context.Set<Product>().ToList();
            // var baskets = context.Set<Basket>().Include(b => b.Cart).ToList();
            //foreach (var p in Products)
            //{
            //    Console.WriteLine(p);
            //}

            //var basket = new Basket();
            //var basket01 = new Basket();
            //var basket02 = new Basket();
            //var p1 = new Product()
            //{
            //    Name = "addidas Shoes",
            //    Category = ProductCategoryId.Shoes,
            //    Price = 125.22M
            //};
            //var p2 = new Product()
            //{
            //    Name = "Nike Shoes",
            //    Category = ProductCategoryId.Shoes,
            //    Price = 105.22M
            //};
            //var p3 = new Product()
            //{
            //    Name = "gap",
            //    Category = ProductCategoryId.Shirt,
            //    Price = 55.22M
            //};

            //basket01.Cart.Add(p1);
            //basket01.Cart.Add(p2);
            //basket02.Cart.Add(p1);
            //basket02.Cart.Add(p2);
            //basket02.Cart.Add(p3);
            //context.Add(basket01);
            //context.Add(basket02);

            //basket.Cart.Add(
            //    new Product()
            //    {
            //        Name = "Jacket",
            //        Category = ProductCategoryId.Shirt,
            //        Price = 15M
            //    });


           // context.SaveChanges();
        }
    }
}
