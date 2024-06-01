
namespace Shop
{
    internal class Shop
    {
        private List<Product> products = new List<Product>();
        public double TotalIncome { get; private set; } = 0;
        public void AddProduct(string name, double price, int count, string productType)
        {
            if (!products.Any(p => p.Name == name))
            {
                Product newProduct;
                if (productType.ToLower() == "c")
                {
                    newProduct = new Coffee(name, price, count);
                }
                else if (productType.ToLower() == "t")
                {
                    newProduct = new Tea(name, price, count);
                }
                else
                {
                    Console.WriteLine("Invalid product type. Please enter 'c' for Coffee or 't' for Tea.");
                    return;
                }

                products.Add(newProduct);
                Console.WriteLine($"Product '{name}' added successfully.");
            }
            else
            {
                Console.WriteLine($"Product '{name}' already exists. Cannot add duplicate products.");
            }
        }
        public void BuyProduct(string name, int count)
        {
            Product product = products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                if (product.Count >= count)
                {
                    double totalPrice = product.Price * count;
                    TotalIncome += totalPrice;
                    product.Count -= count;
                    Console.WriteLine($"Product '{name}' sold successfully. Total price: {totalPrice}.");
                }
                else
                {
                    Console.WriteLine($"Not enough '{name}' in stock.");
                }
            }
            else
            {
                Console.WriteLine($"Product '{name}' not found.");
            }
        }
        public void ShowAvailableProducts()
        {
            Console.WriteLine("Available Products:");
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Count: {product.Count}");
            }
        }
    }
}
