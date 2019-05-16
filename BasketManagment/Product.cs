namespace BasketManagment
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductCategoryId Category { get; set; }


        public Product(int id, string name, decimal price, ProductCategoryId productCategoryId)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = productCategoryId;
        }

        public override string ToString()
        {
            return $"{Id}:{Name}:{Price}:{Category.ToString()}";
        }
    }
}
