namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Buy Product");
                Console.WriteLine("3. View Total Income");
                Console.WriteLine("4. View Available Products");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        string productName = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double productPrice = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter product count: ");
                        int productCount = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter product type (c for Coffee, t for Tea): ");
                        string productType = Console.ReadLine();
                        shop.AddProduct(productName, productPrice, productCount, productType);
                        break;
                    case 2:
                        Console.Write("Enter product name: ");
                        string productNameToBuy = Console.ReadLine();
                        Console.Write("Enter product count: ");
                        int productCountToBuy = Convert.ToInt32(Console.ReadLine());
                        shop.BuyProduct(productNameToBuy, productCountToBuy);
                        break;
                    case 3:
                        Console.WriteLine($"Total Income: {shop.TotalIncome}");
                        break;
                    case 4:
                        shop.ShowAvailableProducts();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}