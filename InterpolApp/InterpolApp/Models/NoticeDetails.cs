using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterpolApp.Models
{
    public class NoticeDetails
    {
        [JsonProperty("forename")]
        public string Forename { get; set; }

        [JsonProperty("name")]
        public string LastName { get; set; }

        [JsonProperty("date_of_birth")]
        public string BirthDate { get; set; }

        [JsonProperty("entity_id")]
        public string Id { get; set; }

        [JsonProperty("nationalities")]
        public string[] Nationalities { get; set; }

        [JsonProperty("_links")]
        public NoticeLinks Links { get; set; }
    }
}
