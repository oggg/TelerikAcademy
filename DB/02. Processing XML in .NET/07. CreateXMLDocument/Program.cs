using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace CreateXMLDocument
{
    class Program
    {
        static void Main()
        {
            List<string> textLines = new List<string>();
            string text;
            try
            {
                StreamReader reader = new StreamReader("../../person.txt");
                while ((text = reader.ReadLine()) != null)
                {
                    textLines.Add(text);
                }

            }
            catch (FileNotFoundException e)
            {

                throw new FileNotFoundException("File could not be found", e);
            }

            string filename = "../../person.xml";
            Encoding encoding = Encoding.GetEncoding("UTF-8");
            using (XmlTextWriter writer = new XmlTextWriter(filename, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("person");
                writer.WriteElementString("name", textLines[0]);
                writer.WriteElementString("address", textLines[1]);
                writer.WriteElementString("phone", textLines[2]);
            }
        }
    }
}
