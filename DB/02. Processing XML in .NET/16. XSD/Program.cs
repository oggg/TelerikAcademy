using System;
using System.Xml;
using System.Xml.Schema;

namespace XSD
{
    class Program
    {
        static void Main()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas.Add("http://www.nakov.com/schemas/library", "../../../catalog.xsd");
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            XmlReader reader = XmlReader.Create("../../../catalog.xml", settings);

            while (reader.Read());
            
        }

        private static void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
            {
                Console.WriteLine("\tWarning: Matching schema not found.  No validation occurred." + args.Message);
            }
            else
            {
                Console.WriteLine("\tValidation error: " + args.Message);
            }
        }
    }
}
