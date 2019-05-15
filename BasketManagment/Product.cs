namespace BasketManagment
{
    class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Category { get; set; }
        //public ProductCategoryId Category { get; set; }


        public Product(int id, string name, double price,int productCategoryId)
        {
            Id = id;
            Name = name;
            Price = price;
            //ProductCategoryId.productCategoryId;
            Category = productCategoryId;
        }

        public override string ToString()
        {
            return $"Id:{Id}\nName:{Name}\nPrice:{Category}\nCategory{Category} ";
        }
    }
}
