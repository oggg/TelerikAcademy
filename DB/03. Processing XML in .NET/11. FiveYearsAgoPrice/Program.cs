using System;
using System.Xml;

namespace FiveYearsAgoPrice
{
    class Program
    {
        static void Main()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../catalog.xml");
            XmlElement root = xmlDoc.DocumentElement;
            int currentYear = DateTime.Now.Year;
            int fiveYearsAgo = currentYear - 5;

            string xpath = string.Format("/catalog/album[year < {0}]", fiveYearsAgo);

            XmlNodeList olderAlbumsPrice = root.SelectNodes(xpath);

            foreach (XmlNode album in olderAlbumsPrice)
            {
                Console.WriteLine(album["price"].InnerText);
            }
        }
    }
}
