namespace KeThua1
{

    public class ShoppingCart
    {
        public List<Product> Products { get; set; }
        public ShoppingCart()
        {
            Products = new List<Product>();
        }
        
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(Product product) 
        {
            Products.Remove(product);
        }
        public double Tinh()
        {
            double tinh = 0;
            foreach (Product product in Products) 
            {
                tinh += product.gia * product.sl;
            }
            return tinh;
        }
        public void onDisplay()
        {
            foreach (var product in Products)
            {
                product.InDisplay();
                Console.WriteLine();
            }
        }
    }
}
