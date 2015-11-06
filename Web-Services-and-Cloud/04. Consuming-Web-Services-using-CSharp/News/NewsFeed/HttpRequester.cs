namespace NewsFeed
{
    using System.IO;
    using System.Net;

    public static class HttpRequester
    {
        public static void Get(string resourceUrl)
        {
            var request = WebRequest.Create(resourceUrl) as HttpWebRequest;
            request.ContentType = "application/json";
            request.Method = "GET";

            var response = request.GetResponse();
            string responseString;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                responseString = reader.ReadToEnd();
            }

            File.WriteAllText("../../../news.xml", responseString);
        }
    }
}
