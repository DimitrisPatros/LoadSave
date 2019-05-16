namespace BasketManagment
{
    public class Product
    {

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductCategoryId Category { get; set; }


        public Product()
        {
            
        }

        public override string ToString()
        {
            return $"{ProductId}:{Name}:{Price}:{Category.ToString()}";
        }
    }
}
