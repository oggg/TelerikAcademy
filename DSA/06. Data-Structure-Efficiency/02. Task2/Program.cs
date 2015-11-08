namespace ArticleCollection
{
    using System;
    using Wintellect.PowerCollections;

    class Program
    {
        private const int BarcodeStart = 380111111;
        private const int BarcodeEnd = 380999999;
        private const int LowerRange = 5;
        private const int UpperRange = 20;
        private const int NumberOfArticles = 10;


        static void Main()
        {
            var articles = new OrderedMultiDictionary<decimal, Article>(true);

            for (int i = 0; i < NumberOfArticles; i++)
            {
                var article = new Article
                {
                    Barcode = ArticleDataGenerator.Barcode(BarcodeStart, BarcodeEnd),
                    Vendor = ArticleDataGenerator.Vendor(LowerRange, UpperRange),
                    Title = ArticleDataGenerator.Title(LowerRange, UpperRange),
                    Price = ArticleDataGenerator.Price(LowerRange, UpperRange)
                };
                articles.Add(article.Price, article);
            }

            SearchInRange(articles, 1000);
        }

        private static void SearchInRange(OrderedMultiDictionary<decimal, Article> articles, int searches)
        {
            for (int i = 0; i < searches; i++)
            {
                decimal min = ArticleDataGenerator.Price(5, 12);
                decimal max = ArticleDataGenerator.Price(15, 20);

                var result = articles.Range(min, true, max, true);

                Console.WriteLine("Lower price: {0}, Higher price: {1}", min, max);
                foreach (var a in result)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine(new string('=', 20));
            }
        }

    }
}