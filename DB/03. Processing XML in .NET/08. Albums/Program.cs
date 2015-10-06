using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Albums
{
    class Program
    {
        static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter("../../album.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                using (XmlReader reader = XmlReader.Create("../../../catalog.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                        {
                            writer.WriteStartElement("album");
                            writer.WriteElementString(reader.Name, reader.ReadElementString());
                            Console.WriteLine(reader.Name);
                            Console.WriteLine();
                        }

                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "artist")
                        {
                            writer.WriteElementString(reader.Name, reader.ReadElementString());
                            writer.WriteEndElement();
                            Console.WriteLine(reader.Name);
                            Console.WriteLine(reader.Value);
                        }
                    }
                }
                writer.WriteEndDocument();
            }
        }
    }
}
