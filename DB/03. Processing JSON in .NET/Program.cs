using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ProcessingJSON
{
    class Program
    {
        static void Main()
        {

            WebClient myWebClient = new WebClient();
            string remoteResource = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string feed = "../../feed.xml";
            myWebClient.DownloadFile(remoteResource, feed);

            XmlDocument doc = new XmlDocument();
            doc.Load(feed);
            string jsonFeed = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
            var jsonObj = JObject.Parse(jsonFeed);

            var titles =
                from e in jsonObj["feed"]["entry"]
                select e["title"];

            var videos = jsonObj["feed"]["entry"]
                        .Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString()));


            StringBuilder html = new StringBuilder();

            html.Append("<!DOCTYPE html><html><body>");
            foreach (var video in videos)
            {
                html.AppendFormat("<div style=\"float:left; width: 420px; height: 450px; padding:10px; " +
                                  "margin:5px; background-color:grey; border-radius:10px\">" +
                                  "<iframe width=\"420\" height=\"345\" " +
                                  "src=\"http://www.youtube.com/embed/{1}?autoplay=0\" " +
                                  "frameborder=\"0\" allowfullscreen></iframe>" +
                                  "<h3>{2}</h3><a href=\"{0}\">Go to YouTube</a></div>",
                                  video.Link.Href, video.Id, video.Title);
            }
            html.Append("</body></html>");

            using (StreamWriter writer = new StreamWriter("../../videos.html", false, Encoding.UTF8))
            {
                writer.Write(html);
            }


        }
    }
}
