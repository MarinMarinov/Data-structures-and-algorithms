namespace Task02TradeCompany
{
    using System;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            var priceRangeMin = 10;
            var priceRangeMax = 20;
            int numberOfProducts = 100000;

            var products = new OrderedMultiDictionary<decimal, Product>(true);

            for (var i = 0; i < numberOfProducts; i++)
            {
                var product = new Product()
                {
                    Price = i%1000,
                    Barcode = string.Format("B{0}{1}", i, i),
                    Vendor = string.Format("Company #" + i),
                    Title = string.Format("Product #" + i)
                };

                if (!products.ContainsKey(product.Price))
                {
                    products.Add(product.Price, product);
                }
                else
                {
                    products[product.Price].Add(product);
                }
            }

            var productsInRange = products.Range(priceRangeMin, true, priceRangeMax, true);

            foreach (var item in productsInRange)
            {
                Console.WriteLine("Products with price: " + item.Key);
                Console.WriteLine(string.Join(Environment.NewLine, item.Value.Select(v => string.Join(Environment.NewLine, "   " + v.ToString()))));
            }
        }
    }
}