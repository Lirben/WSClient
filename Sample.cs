using System;
using LibEquine;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace WSClient
{
    class Sample
    {
        [JsonProperty("hoof")]
        public Types.HoofLocation hoof { get; set; }

        [JsonProperty("timestamp")]
        public uint timestamp { get; set; }

        [JsonPropertyAttribute("forcevalues")]
        public int[] forcevalues { get; set; }

        public Sample(Types.HoofLocation hoof, uint timestamp, int[] forcevalues)
        {
            this.hoof = hoof;
            this.timestamp = timestamp;
            this.forcevalues = forcevalues;
        }
    }
}
