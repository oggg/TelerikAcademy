namespace ArticleCollection
{
    using System;
    using System.Linq;

    public static class ArticleDataGenerator
    {
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private const decimal ConvertPrice = 0.45m;

        private static Random rnd = new Random();

        public static int Barcode(int BarcodeStart, int BarcodeEnd)
        {
            return rnd.Next(BarcodeStart, BarcodeEnd);
        }

        public static string Vendor(int LowerRange, int UpperRange)
        {
            return RandomString(rnd.Next(LowerRange, UpperRange));
        }

        public static string Title(int LowerRange, int UpperRange)
        {
            return RandomString(rnd.Next(LowerRange, UpperRange));
        }

        public static decimal Price(int lowerPrice, int upperPrice)
        {
            return rnd.Next(lowerPrice, upperPrice) * ConvertPrice;
        }

        private static string RandomString(int length)
        {
            return new string(
                Enumerable
                .Repeat(Chars, length)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

    }
}
