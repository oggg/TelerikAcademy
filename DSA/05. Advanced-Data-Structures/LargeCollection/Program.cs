namespace LargeCollection
{
    using System;
    using System.Linq;
    using Wintellect.PowerCollections;

    class Program
    {
        private const int AllProducts = 500000;
        private const int PriceSearches = 10000;

        static void Main()
        {
            var bigBag = new OrderedBag<Product>();
            var priceBag = new OrderedBag<decimal>();

            for (int i = 0; i < AllProducts; i++)
            {
                var product = new Product
                {
                    Name = "Product" + i,
                    Price = AllProducts - i * 0.75m,
                };
                bigBag.Add(product);
                priceBag.Add(product.Price);
            }

            Console.WriteLine(bigBag[0]);
            Console.WriteLine(bigBag[AllProducts - 1]);

            for (int j = 0; j < PriceSearches; j++)
            {
                var lowerPrice = j + bigBag[0].Price;
                var higherPrice = j + 30 + bigBag[0].Price;
                var priceRangeProducts = bigBag.Where(p => p.Price > lowerPrice && p.Price < higherPrice).Take(20);
            }
        }
    }
}
