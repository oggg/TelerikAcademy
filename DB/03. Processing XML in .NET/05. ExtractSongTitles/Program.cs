using System;
using System.Xml;

namespace ExtractSongTitles
{
    class Program
    {
        static void Main()
        {
            using (XmlReader reader = XmlReader.Create("../../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine("Song title -> {0}", reader.ReadElementString());
                    }
                }
            }
        }
    }
}
