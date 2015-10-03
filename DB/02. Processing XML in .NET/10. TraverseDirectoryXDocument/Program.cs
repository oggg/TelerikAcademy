using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TraverseDirectoryXDocument
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Using the project folder for traversing!");
            DirectoryInfo rootDir = new DirectoryInfo("../../");

            var dirListing = TraversingDirectories(rootDir.ToString());
            dirListing.Save("../../../dirlist.xml");
        }

        static XElement TraversingDirectories(string dir)
        {
            var node = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                node.Add(TraversingDirectories(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                node.Add(new XElement("file", new XAttribute("name", Path.GetFileName(file))));
            }
            return node;
        }
    }
}
