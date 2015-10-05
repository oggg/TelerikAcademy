using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProcessingJSON
{
    class Video
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

    }
}
