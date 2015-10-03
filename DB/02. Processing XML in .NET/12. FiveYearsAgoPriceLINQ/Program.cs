using System;
using System.Linq;
using System.Xml.Linq;

namespace FiveYearsAgoPriceLINQ
{
    class Program
    {
        static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../../catalog.xml");
            int fiveYearsAgo = DateTime.Now.Year - 5;

            var albums =
                from album in xmlDoc.Descendants("album")
                where int.Parse(album.Element("year").Value) < fiveYearsAgo
                select new
                {
                    Price = album.Element("price").Value
                };
            foreach (var album in albums)
            {
                Console.WriteLine(album.Price);
            }
        }
    }
}
