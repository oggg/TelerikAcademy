using System;
using System.Collections.Generic;
using System.Xml;

namespace RemoveAlbumsAbove20
{
    class Program
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            XmlNode root = doc.DocumentElement;
            RemoveExpensiveAlbums(root, 20);
            doc.Save("../../RemovedExpensiveAlbums.xml");

        }

        private static void RemoveExpensiveAlbums(XmlNode root, float price)
        {
            List<XmlNode> albumsToRemove = new List<XmlNode>();
            foreach (XmlElement node in root.ChildNodes)
            {
                if (float.Parse(node["price"].InnerText) > price)
                {
                    albumsToRemove.Add(node);
                }
            }

            foreach (XmlElement expensive in albumsToRemove)
            {
                root.RemoveChild(expensive);
            }
        }
    }
}
