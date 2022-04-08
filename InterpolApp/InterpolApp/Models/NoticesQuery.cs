using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterpolApp.Models
{
    public class NoticesQuery
    {
        public int Total { get; set; }

        public Query Query { get; set; }

        [JsonProperty("_embedded")]
        public Embedded Embedded { get; set; }

        [JsonProperty("_links")]
        public QueryLinks Links { get; set; }
    }
}
