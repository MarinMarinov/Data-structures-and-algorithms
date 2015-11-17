namespace Task02
{
    using System;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    class Startup
    {
        static void Main()
        {
            var collection = new OrderedBag<Product>();
            int numberOfProducts = 500000;
            int numberOfProductsToTake = 10000;

            Console.WriteLine("Products generation started");
            for (var i = 0; i < numberOfProducts; i++)
            {
                var product = new Product("Product #" + i, (decimal)i);
                collection.Add(product);
            }
            Console.WriteLine("Products generated");

            var stringBuilder = new StringBuilder();

            Console.WriteLine("Collecting products...");
            for (var i = 0; i < numberOfProductsToTake; i++)
            {
                var rangeOfProducts =
                    collection.Range(new Product("StartSearchProduct", 154000m), true, new Product("EndSearchProduct", 155000m), true)
                        .Take(20);
                stringBuilder.AppendLine(string.Join(", ", rangeOfProducts.Select(p => p.ToString())));
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}