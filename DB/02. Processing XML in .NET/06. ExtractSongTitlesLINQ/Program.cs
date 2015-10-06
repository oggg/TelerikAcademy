using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExtractSongTitlesLINQ
{
    class Program
    {
        static void Main()
        {
            XDocument doc = XDocument.Load("../../../catalog.xml");
            var titles = from title in doc.Descendants("title") select title.Value;
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
