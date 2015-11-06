namespace NewsFeed
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class Program
    {
        private const string FeedURI = @"http://www.dnevnik.bg/rss";

        static void Main()
        {
            HttpRequester.Get(FeedURI);

            XmlDocument doc = new XmlDocument();
            doc.Load("../../../news.xml");

            XmlNodeList items = doc.GetElementsByTagName("item");

            var feedList = XMLDeserialize(items);

            PrintFeed(feedList);
        }

        private static IList<Feed> XMLDeserialize(XmlNodeList items)
        {
            var feeds = new List<Feed>();

            for (int i = 0; i < items.Count; i++)
            {
                var feed = new Feed
                {
                    Title = items[i]["title"].InnerText,
                    Link = items[i]["link"].InnerText
                };
                feeds.Add(feed);
            }

            return feeds;
        }

        private static void PrintFeed(IEnumerable<Feed> feedList)
        {
            foreach (var item in feedList)
            {
                Console.WriteLine("Feed title: {0}", item.Title);
                Console.WriteLine("Feed link: {0}", item.Link);
                Console.WriteLine(new string('*', 20));
            }
        }
    }
}
