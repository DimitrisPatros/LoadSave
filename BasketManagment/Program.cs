using System;

namespace BasketManagment
{
    class Program
    {
        public static void Main(string[] args)
        {
            var context = new OrderManagmentDbContext();

            var basket = new Basket();

            basket.Cart.Add(
                new Product()
                {
                    Name = "Nike Shoes",
                    Category = ProductCategoryId.Shoes,
                    Price = 105.22M
                });

            basket.Cart.Add(
                new Product()
                {
                    Name = "Jacket",
                    Category = ProductCategoryId.Shirt,
                    Price = 15M
                });

            context.Add(basket);
            context.SaveChanges();
        }
    }
}
