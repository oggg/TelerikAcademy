using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace TraverseDirectory
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Using the project folder for traversing!");
            DirectoryInfo rootDir = new DirectoryInfo("../../");

            using (XmlTextWriter writer = new XmlTextWriter("../../directories.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("directories");
                
                TraversingDirectories(rootDir, writer);
                
                writer.WriteEndElement();

            }
        }

        static void TraversingDirectories(DirectoryInfo rootDir, XmlTextWriter writer)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            try
            {
                files = rootDir.GetFiles();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            writer.WriteStartElement("directory");
            writer.WriteAttributeString("name", rootDir.Name);
            
            if (files != null)
            {
                writer.WriteStartElement("files");
                foreach (var file in files)
                {
                    writer.WriteElementString("file", file.Name);
                }
                subDirs = rootDir.GetDirectories();
                foreach (var dir in subDirs)
                {
                    TraversingDirectories(dir, writer);
                }
            }

            writer.WriteEndElement();
        }
    }
}
