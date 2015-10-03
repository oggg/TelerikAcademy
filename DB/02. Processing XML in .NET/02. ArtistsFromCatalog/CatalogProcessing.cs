using System;
using System.Collections.Generic;
using System.Xml;

namespace ArtistsFromCatalog
{
    class CatalogProcessing
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            
            XmlNodeList artists = doc.GetElementsByTagName("artist");

            var albums = Albums(artists);

            foreach (var album in albums)
            {
                Console.WriteLine("Artist: {0} -> albums {1}", album.Key, album.Value);
            }
        }

        private static Dictionary<string, int> Albums(XmlNodeList artists)
        {
            var numberOfAlbums = new Dictionary<string, int>();

            for (int i = 0; i < artists.Count; i++)
            {
                var currentArtist = artists[i].InnerText;
                if (numberOfAlbums.ContainsKey(artists[i].InnerText))
                {
                    numberOfAlbums[currentArtist]++;
                }
                else
                {
                    numberOfAlbums.Add(currentArtist, 1);
                }
            }

            return numberOfAlbums;
        }
    }
}
