using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playground
{
    public class Slip
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("advice")]
        public string advice { get; set; }
    }
}
